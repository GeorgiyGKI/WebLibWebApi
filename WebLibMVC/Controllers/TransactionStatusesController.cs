using Microsoft.AspNetCore.Mvc;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class TransactionStatusesController : Controller
    {
        private readonly IServiceManager _service;
        public TransactionStatusesController(IServiceManager serviceManager) => 
            _service = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var transactionStatuses = await _service.TransactionStatusService.GetAllTransactionStatusesAsync();
            return View(transactionStatuses);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionStatusViewModel transactionStatus)
        {

            if (ModelState.IsValid)
                await _service.TransactionStatusService.AddTransactionStatusAsync(transactionStatus);
            else
                return Create();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var transactionStatus = await _service.TransactionStatusService.GetTransactionStatusAsync(id);

            if (transactionStatus == null)
                return NotFound();

            return View(transactionStatus);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TransactionStatusViewModel transactionStatus)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _service.TransactionStatusService.UpdateTransactionStatusAsync(transactionStatus, id);
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the Transaction Status.");
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
            var transactionStatus = await _service.TransactionStatusService.GetTransactionStatusAsync(id);

            if (transactionStatus == null)
                return NotFound();

            return View(transactionStatus);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isSuccessful = await _service.TransactionStatusService.DeleteTransactionStatusAsync(id);

            if (isSuccessful)
                return RedirectToAction("Index");

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }
    }
}
