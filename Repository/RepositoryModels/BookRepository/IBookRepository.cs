using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.BookRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<PagedList<Book>> GetBooksForPageAsync(BookParameters bookParameters,bool trackChanges);
        Task<Book> GetBookAsync(int bookId, bool trackChanges);
        void CreateBook(Book book);
        void DeleteBook(Book book);
    }
}
