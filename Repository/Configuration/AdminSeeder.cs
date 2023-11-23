using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class AdminSeeder
    {
        private readonly RepositoryContext _context;
        private readonly UserManager<Admin> _userManager;
        public AdminSeeder(RepositoryContext context, UserManager<Admin> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task Seed()
        {
            if (!await _context.Users.AnyAsync())
            {
                var admin = new Admin()
                {
                    UserName = "admin",
                    Email = "admin@test.com",
                    
                };
                var moderator = new Admin()
                {
                    UserName = "moderator",
                    Email = "moderator@test.com",

                };
                await _userManager.CreateAsync(admin, "W0wPassw0rdF0rAdmin");
                await _userManager.CreateAsync(moderator, "W0wPassw0rdF0rModerator");

                await _userManager.AddToRoleAsync(admin, "Administrator");
                await _userManager.AddToRoleAsync(moderator, "Moderator");
            }
        }
    }
}
