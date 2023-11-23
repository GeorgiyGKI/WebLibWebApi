using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.GenreRepository
{
    
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllGenresAsync(bool trackChanges);
        Task<Genre> GetGenreAsync(int genreId, bool trackChanges);
        void CreateGenre(Genre genre);
        void DeleteGenre(Genre genre);
    }
}
