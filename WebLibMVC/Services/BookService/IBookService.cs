using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.BookService
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetAllBooksAsync();
        Task<bool> AddBookAsync(BookViewModel bookViewModel);
        Task<bool> DeleteBookAsync(int id);
        Task<(IEnumerable<BookViewModel>, MetaData metaData)> GetBooksForPageAsync(int pageNumber, int? maxYear, int? minYear, string? searchTerm, string? orderBy);
        Task<BookViewModel> GetBookAsync(int id);
        Task<bool> UpdateBookAsync(BookViewModel bookViewModel, int id);
        Task<bool> TakeBookAsync(int id);
    }
}
