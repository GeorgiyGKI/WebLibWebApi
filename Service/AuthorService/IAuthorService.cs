using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AuthorService
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync(bool trackChanges);
        Task<AuthorDto> GetAuthorAsync(int id, bool trackChanges);
        Task<AuthorDto> CreateAuthorAsync(AuthorDto author);
        Task DeleteAuthorAsync(int id, bool trackChanges);
        Task UpdateAuthorAsync(int id, AuthorDto authorForUpdate, bool trackChanges);
    }
}
