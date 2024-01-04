using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ReadersController(IServiceManager service) =>
             _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetReaders()
        {
            var readers = await _service.ReaderService.GetAllReadersAsync(trackChanges: false);
            return readers != null ? Ok(readers) : NotFound();
        }

        [HttpGet("{id:int}", Name = "ReaderById")]
        [Authorize(Roles = "Moderator, Administrator")]
        public async Task<IActionResult> GetReader(int id)
        {
            var reader = await _service.ReaderService.GetReaderAsync(id, trackChanges: false);
            return reader != null ? Ok(reader) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateReader([FromBody] ReaderDto reader)
        {
            await _service.ReaderService.CreateReaderAsync(reader);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteReader(int id)
        {
            await _service.ReaderService.DeleteReaderAsync(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateReader(int id, [FromBody] ReaderDto reader)
        {
            await _service.ReaderService.UpdateReaderAsync(id, reader, trackChanges: true);
            return NoContent();
        }
    }

}
