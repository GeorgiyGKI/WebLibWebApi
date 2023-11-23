using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionStatusesController : Controller
    {
        private readonly IServiceManager _service;
        public TransactionStatusesController(IServiceManager service) =>
             _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetTransactionStatuses()
        {
            var transactionStatuses = await _service.TransactionStatusService.GetAllTransactionStatusesAsync(trackChanges: false);
            
            return transactionStatuses != null ? Ok(transactionStatuses) : NotFound();
        }

        [HttpGet("{id:int}", Name = "TransactionStatusById")]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetTransactionStatus(int id)
        {
            var transactionStatus = await _service.TransactionStatusService.GetTransactionStatusAsync(id, trackChanges: false);
            
            return transactionStatus != null ? Ok(transactionStatus) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateTransactionStatus([FromBody] TransactionStatusDto transactionStatus)
        {
            await _service.TransactionStatusService.CreateTransactionStatusAsync(transactionStatus);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteTransactionStatus(int id)
        {
            await _service.TransactionStatusService.DeleteTransactionStatusAsync(id, trackChanges: false);
            
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateTransactionStatus(int id, [FromBody] TransactionStatusDto transactionStatus)
        {
            await _service.TransactionStatusService.UpdateTransactionStatusAsync(id, transactionStatus, trackChanges: true);
            
            return NoContent();
        }
    }
}
