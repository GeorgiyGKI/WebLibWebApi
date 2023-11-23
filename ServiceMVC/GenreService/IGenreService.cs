using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.GenreService
{
    public interface IGenreService
    {
        Task<bool> AddGenreAsync(GenreViewModel genreViewModel);
        Task<bool> DeleteGenreAsync(int id);
        Task<IEnumerable<GenreViewModel>> GetAllGenresAsync();
        Task<GenreViewModel> GetGenreAsync(int id);
        Task<bool> UpdateGenreAsync(GenreViewModel genreViewModel, int id);
    }
