using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly IServiceManager _service;
        public BooksController(IServiceManager serviceManager) => _service = serviceManager;

        public async Task<IActionResult> Create()
        {
            var bookViewModel = new BookViewModel();

            var authors = await _service.AuthorService.GetAllAuthorsAsync();
            var genres = await _service.GenreService.GetAllGenresAsync();

            bookViewModel.Authors.AddRange(authors.Select(author => new SelectListItem
            {
                Value = author.Id.ToString(),
                Text = $"{author.FirstName} {author.LastName}"
            }));

            bookViewModel.Genres.AddRange(genres.Select(genre => new SelectListItem
            {
                Value = genre.Id.ToString(),
                Text = genre.Name
            }));

            return View(bookViewModel);
        }
        public async Task<IActionResult> Index()
        {
            var books = await _service.BookService.GetAllBooksAsync();
           
            foreach (var book in books)
            {
                var author = await _service.AuthorService.GetAuthorAsync(book.AuthorId);
                var genre = await _service.GenreService.GetGenreAsync(book.GenreId);
                book.AuthorName = $"{author.FirstName} {author.LastName}";
                book.GenreName = genre.Name;
            }
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel book)
        {
            if (ModelState.IsValid)
                await _service.BookService.AddBookAsync(book);
            else
                return await Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _service.BookService.GetBookAsync(id);

            if (book == null)
                return NotFound();

            var authors = await _service.AuthorService.GetAllAuthorsAsync();
            var genres = await _service.GenreService.GetAllGenresAsync();

            book.Authors.AddRange(authors.Select(author => new SelectListItem
            {
                Value = author.Id.ToString(),
                Text = $"{author.FirstName} {author.LastName}"
            }));

            book.Genres.AddRange(genres.Select(genre => new SelectListItem
            {
                Value = genre.Id.ToString(),
                Text = genre.Name
            }));

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, BookViewModel book)
        {
            if (ModelState.IsValid)
                await _service.BookService.UpdateBookAsync(book, id);
            else
                return await Edit(id);
            

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var book = await _service.BookService.GetBookAsync(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isSuccessful = await _service.BookService.DeleteBookAsync(id);

            if (isSuccessful)
                return RedirectToAction("Index");

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }

        public async Task<IActionResult> GetImage(int id)
        {
            var menuItem = await _service.BookService.GetBookAsync(id); ///!!!!!!!!

            byte[] imageData;
            if (menuItem.Image != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    menuItem.Image.CopyTo(memoryStream);
                    imageData = memoryStream.ToArray();
                }

                if (menuItem.Image != null)
                    return File(imageData, $"image/{menuItem.Image.FileName}");

            }

            return NotFound();
        }
    }
}
