using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BookService
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetAllBooksAsync(bool trackChanges);
        Task<BookDto> GetBookAsync(int id, bool trackChanges);
        Task<BookDto> CreateBookAsync(BookDto book);
        Task DeleteBookAsync(int id, bool trackChanges);
        Task UpdateBookAsync(int id, BookDto bookForUpdate, bool trackChanges);
    }
}
