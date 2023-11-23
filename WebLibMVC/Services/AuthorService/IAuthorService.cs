using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.AuthorService
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorViewModel>> GetAllAuthorsAsync();
        Task<AuthorViewModel> GetAuthorAsync(int id);
        Task<bool> AddAuthorAsync(AuthorViewModel authorDto);
        Task<bool> UpdateAuthorAsync(AuthorViewModel authorDto, int id);
        Task<bool> DeleteAuthorAsync(int id);
    }
}
