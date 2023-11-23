using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class Admin : IdentityUser
    {
        public string? Password { get; set; }
    }
}
