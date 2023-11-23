using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : Controller
    {
        private readonly IServiceManager _service;
        public TransactionsController(IServiceManager service) =>
             _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet("{readerId:int}")]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetTransactions(int readerId)
        {
            var transactions = await _service.TransactionService.GetAllTransactionsAsync(readerId, trackChanges: false);
          
            return transactions != null ? Ok(transactions) : NotFound();
        }

        [HttpGet("{readerId:int}/{id:int}", Name = "TransactionById")]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetTransaction(int readerId, int id)
        {
            var transaction = await _service.TransactionService.GetTransactionAsync(readerId, id, trackChanges: false);
           
            return transaction != null ? Ok(transaction) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateTransaction([FromBody] TransactionDto transaction)
        {
            await _service.TransactionService.CreateTransactionAsync(transaction);

            return NoContent();
        }

        [HttpDelete("{readerId:int}/{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteTransaction(int readerId, int id)
        {
            await _service.TransactionService.DeleteTransactionAsync(readerId, id, trackChanges: false);
          
            return NoContent();
        }

        [HttpPut("{readerId:int}/{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateTransaction(int readerId, int id, [FromBody] TransactionDto transaction)
        {
            await _service.TransactionService.UpdateTransactionAsync(readerId, id, transaction, trackChanges: true);
           
            return NoContent();
        }
    }
}
