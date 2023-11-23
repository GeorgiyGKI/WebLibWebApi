using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Shared.DataTransferObject;

namespace Service.AuthenticationService;
public interface IAuthenticationService
{
    Task<bool> ValidateAdmin(AuthorizeDto authorizeDto);
    Task<ICollection<string>> GetRoles();
    Task<string> CreateToken();
}