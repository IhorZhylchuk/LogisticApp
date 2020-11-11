using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2.Models
{
    public static class SeedDB
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = ADMIN_ID;

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "Administrator"
            });

            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            { 
                Id = ADMIN_ID,
                UserName = "Sara",
                Email = "sara@gmail.com",
                EmailConfirmed = true,
                NormalizedUserName = "Sara",
                NormalizedEmail = "sara@gmail.com",
                PasswordHash = hasher.HashPassword(null, "qwerty12345"),
                SecurityStamp = string.Empty            
            }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });            
        }
    }
}
