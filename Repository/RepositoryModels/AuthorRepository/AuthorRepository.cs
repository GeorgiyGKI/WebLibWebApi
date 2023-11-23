using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.AuthorRepository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Author> GetAuthorAsync(int authorId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.Id.Equals(authorId), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateAuthor(Author author) => Create(author);

        public void DeleteAuthor(Author author) => Delete(author);
    }

}
