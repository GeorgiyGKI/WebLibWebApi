using Microsoft.AspNetCore.Mvc;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class ReadersController : Controller
    {
        private readonly IServiceManager _service;
        public ReadersController(IServiceManager serviceManager) =>
            _service = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var readers = await _service.ReaderService.GetAllReadersAsync();
            return View(readers);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReaderViewModel reader)
        {
            if (ModelState.IsValid)
                await _service.ReaderService.AddReaderAsync(reader);
            else
                return Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var reader = await _service.ReaderService.GetReaderAsync(id);

            if (reader == null)
                return NotFound();

            return View(reader);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ReaderViewModel reader)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.ReaderService.UpdateReaderAsync(reader, id);
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the Reader.");
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
            var reader = await _service.ReaderService.GetReaderAsync(id);

            if (reader == null)
                return NotFound();

            return View(reader);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isSuccessful = await _service.ReaderService.DeleteReaderAsync(id);

            if (isSuccessful)
                return RedirectToAction("Index");

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }
    }

}
