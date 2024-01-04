using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;
using WebLibWebApi.Action_Filters;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IServiceManager _service;

        public GenresController(IServiceManager service) =>
            _service = service ?? throw new ArgumentNullException(nameof(service));

        [HttpGet]
        public async Task<IActionResult> GetGenres()
        {
            var genres = await _service.GenreService.GetAllGenresAsync(trackChanges: false);

            return genres != null ? Ok(genres) : NotFound();
        }

        [HttpGet("{id:int}", Name = "GenreById")]
        public async Task<IActionResult> GetGenre(int id)
        {
            var genre = await _service.GenreService.GetGenreAsync(id, trackChanges: false);

            return genre != null ? Ok(genre) : NotFound();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateGenre([FromBody] GenreDto genre)
        {
            await _service.GenreService.CreateGenreAsync(genre);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteGenre(int id)
        {
            await _service.GenreService.DeleteGenreAsync(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> UpdateGenre(int id, [FromBody] GenreDto genre)
        {
            await _service.GenreService.UpdateGenreAsync(id, genre, trackChanges: true);

            return NoContent();
        }
    }

}
