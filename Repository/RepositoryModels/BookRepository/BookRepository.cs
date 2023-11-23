using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.BookRepository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Book> GetBookAsync(int bookId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.Id.Equals(bookId), trackChanges)
                .SingleOrDefaultAsync();

        public void CreateBook(Book book) => Create(book);

        public void DeleteBook(Book book) => Delete(book);
    }

   

}
