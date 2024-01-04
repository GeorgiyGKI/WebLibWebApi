using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthorsController(IServiceManager service) =>
             _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await _service.AuthorService.GetAllAuthorsAsync(trackChanges: false);
            return authors != null ? Ok(authors) : NotFound();
        }

        [HttpGet("{id:int}", Name = "AuthorById")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var author = await _service.AuthorService.GetAuthorAsync(id, trackChanges: false);
            return author != null ? Ok(author) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDto author)
        {
            await _service.AuthorService.CreateAuthorAsync(author);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            await _service.AuthorService.DeleteAuthorAsync(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateAuthor(int id, [FromBody] AuthorDto author)
        {
            await _service.AuthorService.UpdateAuthorAsync(id, author, trackChanges: true);
            return NoContent();
        }
    }

}
