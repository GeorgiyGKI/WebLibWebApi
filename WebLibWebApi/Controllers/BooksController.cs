using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using Shared.RequestFeatures;
using System.Text.Json;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase   
    {
        private readonly IServiceManager _service;

        public BooksController(IServiceManager service) => 
            _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet("ListOfBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _service.BookService.GetAllBooksAsync(trackChanges: false);
            return books != null ? Ok(books) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks([FromQuery] BookParameters bookParameters)
        {
            var (books, metaData) = await _service.BookService.GetBooksForPageAsync(bookParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metaData));

            return Ok(books);
        }

        [HttpGet("{id:int}", Name = "BookById")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _service.BookService.GetBookAsync(id, trackChanges: false);

            return book != null ? Ok(book) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateBook([FromBody] BookDto book)
        {
            await _service.BookService.CreateBookAsync(book);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _service.BookService.DeleteBookAsync(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] BookDto book)
        {
            await _service.BookService.UpdateBookAsync(id, book, trackChanges: true);

            return NoContent();
        }
    }

}
