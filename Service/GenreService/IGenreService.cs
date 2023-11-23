using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.GenreService
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDto>> GetAllGenresAsync(bool trackChanges);
        Task<GenreDto> GetGenreAsync(int id, bool trackChanges);
        Task<GenreDto> CreateGenreAsync(GenreDto genre);
        Task DeleteGenreAsync(int id, bool trackChanges);
        Task UpdateGenreAsync(int id, GenreDto genreForUpdate, bool trackChanges);
    }
}
