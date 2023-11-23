using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceMVC.ServiceManager;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly IServiceManager _service;
        public TransactionsController(IServiceManager serviceManager) => _service = serviceManager;

        public async Task<IActionResult> Create(int readerId)
        {
            var books = await _service.BookService.GetAllBooksAsync();
            var transactionViewModel = new TransactionViewModel();

            transactionViewModel.Books.AddRange(books.Select(book => new SelectListItem
            {
                Value = book.Id.ToString(),
                Text = book.Title
            }));

            ViewBag.ReaderId = readerId;

           
            return View(transactionViewModel);
        }

        public async Task<IActionResult> Index(int readerId)
        {
            var transactions = await _service.TransactionService.GetAllTransactionsAsync(readerId);
            ViewBag.ReaderId = readerId;
            foreach (var transaction in transactions)
            {
                var reader = await _service.ReaderService.GetReaderAsync(readerId);
                var book = await _service.BookService.GetBookAsync(transaction.BookId);
                var status = await _service.TransactionStatusService.GetTransactionStatusAsync(transaction.TransactionStatusId);
                transaction.ReaderName = $"{reader.FirstName} {reader.LastName}";
                transaction.BookName = book.Title;
                transaction.TransactionStatusName = status.Name;
            }
            return View(transactions);
        }
        [HttpPost]
        public async Task<IActionResult> Create(int readerId, TransactionViewModel transaction)
        {
            var reader = _service.ReaderService.GetReaderAsync(readerId);
            
            if (ModelState.IsValid && reader is not null)
            {
                transaction.ReaderId = readerId;
                await _service.BookService.TakeBookAsync(transaction.BookId);
                transaction.CheckoutDate = DateTime.Now.AddDays(30);

                await _service.TransactionService.AddTransactionAsync(transaction);
            }
            else
            {
                return await Create(readerId);
            }

            return RedirectToAction("Index", new { readerId });
        }
        public async Task<IActionResult> Close(int readerId, int id)
        {
            var response = await _service.TransactionService.CloseTransactionAsync(readerId, id);

            return RedirectToAction("Index", new { readerId });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int readerId, int id)
        {
            var transaction = await _service.TransactionService.GetTransactionAsync(readerId, id);
            if (transaction == null)
                return NotFound();

            var books = await _service.BookService.GetAllBooksAsync();
            var transactionStatuses = await _service.TransactionStatusService.GetAllTransactionStatusesAsync();

            transaction.Books.AddRange(books.Select(book => new SelectListItem
            {
                Value = book.Id.ToString(),
                Text = book.Title
            }));

            transaction.TransactionStatuses.AddRange(transactionStatuses.Select(status => new SelectListItem
            {
                Value = status.Id.ToString(),
                Text = status.Name
            }));

            return View(transaction);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int readerId, int id, TransactionViewModel transaction)
        {
            var reader = _service.ReaderService.GetReaderAsync(readerId);

            if (ModelState.IsValid & reader is not null)
            {
                try
                {
                    await _service.TransactionService.UpdateTransactionAsync(transaction, readerId, id);
                }
                catch (HttpRequestException)
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while updating the Transaction.");
                }
            }
            else
            {
                return await Edit(readerId, id);
            }

            return RedirectToAction("Index", new { readerId });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int readerId, int id)
        {
            var transaction = await _service.TransactionService.GetTransactionAsync(readerId, id);

            if (transaction == null)
                return NotFound();

            return View(transaction);
        }

        [HttpPost(), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int readerId, int id)
        {
            bool isSuccessful = await _service.TransactionService.DeleteTransactionAsync(readerId, id);

            if (isSuccessful)
                return RedirectToAction("Index", new { readerId });

            return RedirectToAction("Delete", new { id, errorMessage = "error during deletion" });
        }
    }

}
