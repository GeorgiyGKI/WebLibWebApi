using Entities.Models;

namespace Repository.RepositoryModels.AuthorRepository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthorsAsync(bool trackChanges);
        Task<Author> GetAuthorAsync(int authorId, bool trackChanges);
        void CreateAuthor(Author author);
        void DeleteAuthor(Author author);
    }
}

