using Microsoft.AspNetCore.Mvc;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IServiceManager _service;
        public AuthorsController(IServiceManager serviceManager) => _service = serviceManager;

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {

            var authors = await _service.AuthorService.GetAllAuthorsAsync();
            return View(authors);
        }
        public async Task<IActionResult> GetAuthor(int id)
        {
            var authors = await _service.AuthorService.GetAuthorAsync(id);
            return View(authors);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuthorViewModel author)
        {
            if (ModelState.IsValid)
                await _service.AuthorService.AddAuthorAsync(author);
            else
                return Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var author = await _service.AuthorService.GetAuthorAsync(id);

            if (author == null)
                return NotFound();

            return View(author);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AuthorViewModel author)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.AuthorService.UpdateAuthorAsync(author, id);
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the Author.");
                }
            }
            else
            {
                return await Edit(id);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var author = await _service.AuthorService.GetAuthorAsync(id);

            if (author == null)
                return NotFound();

            return View(author);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isSuccessful = await _service.AuthorService.DeleteAuthorAsync(id);

            if (isSuccessful)
                return RedirectToAction("Index");

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }
    }

}
