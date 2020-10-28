using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2.Models
{
    public static class SeedUsers
    {
        public static void SeedData(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            SeedUsser(userManager);
            SeedRole(roleManager);
            
        }

        private static void SeedUsser(UserManager<IdentityUser> userManager)
        {
            IdentityUser user = new IdentityUser();
            user.UserName = "Sara";
            user.Email = "sara@gmail.com";
            
            IdentityResult resultUser =  userManager.CreateAsync(user, "qwerty12345").Result;

                if (resultUser.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();

                }
        }

        private static void SeedRole(RoleManager<IdentityRole> roleManager)
        {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult result_1 = roleManager.CreateAsync(role).Result;

                IdentityRole role_2 = new IdentityRole();
                role_2.Name = "User";
                IdentityResult result_2 = roleManager.CreateAsync(role_2).Result;
        }
    }
}
