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

            const string USER_ID = "a15be3c1-aa45-4af6-bd17-00bd9376e455";
            const string USER_ROLE_ID = ADMIN_ID;

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "Administrator"
            }, new IdentityRole { 
                Id = USER_ID,
                Name = "User"
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
            
            },
            new IdentityUser
            {
                Id = USER_ID,
                UserName = "Petro",
                Email = "petro@gmail.com",
                EmailConfirmed = true,
                NormalizedUserName = "Petro",
                NormalizedEmail = "petro@gmail.com",
                PasswordHash = hasher.HashPassword(null, "qwerty12345"),
                SecurityStamp = string.Empty
            }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            }, new IdentityUserRole<string> { 
                RoleId = USER_ROLE_ID,
                UserId = USER_ID
            });
            
        }
    }
}
