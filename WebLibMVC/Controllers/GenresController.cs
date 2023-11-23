using Microsoft.AspNetCore.Mvc;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class GenresController : Controller
    {
        private readonly IServiceManager _service;
        public GenresController(IServiceManager serviceManager) => 
            _service = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var genres = await _service.GenreService.GetAllGenresAsync();
            return View(genres);
        }

        [HttpPost]
        public async Task<IActionResult> Create(GenreViewModel genre)
        {
            if (ModelState.IsValid)
                await _service.GenreService.AddGenreAsync(genre);
            else
                return Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var genre = await _service.GenreService.GetGenreAsync(id);

            if (genre == null)
                return NotFound();
            
            return View(genre);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, GenreViewModel genre)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.GenreService.UpdateGenreAsync(genre, id);
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the Category.");
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
            var genre = await _service.GenreService.GetGenreAsync(id);

            if (genre == null)
                return NotFound();

            return View(genre);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isSuccessful = await _service.GenreService.DeleteGenreAsync(id);

            if (isSuccessful)
                return RedirectToAction("Index");

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }
    }
}
