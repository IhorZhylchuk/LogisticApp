using Logistic_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    { 
        public DbSet<ProductsItems> Products { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedDB.SeedData(builder);
        }
    }
}
