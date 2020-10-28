using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Logistic_2.Models;


namespace Logistic_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
             var host = CreateHostBuilder(args).Build();
            /*
            using(var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                try
                {
                    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    var userRole = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    SeedUsers.SeedData(userRole, userManager);
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            */
             host.Run();
           
           // }     
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
