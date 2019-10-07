using JWTAuthentication.Controllers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginWithAuthKey.Models
{
    
        public class AuthenticateUser : IdentityDbContext
    {
        public AuthenticateUser(DbContextOptions options) : base(options)
        {
            ApplicationUsers.Add(new UserModel(){UserName = "Rahul",
                Email = "r@gmail.com",
                FullName = "Rahul Tiwari",
                Role = "Admin"});
            ApplicationUsers.Add(new UserModel()
            {
                UserName = "Prakhar",
                Email = "p@gmail.com",
                FullName = "Prakhar Gupta",
                Role = "Trainee"
            });
        }

        public DbSet<UserModel> ApplicationUsers { get; set; }
        
    }
}
