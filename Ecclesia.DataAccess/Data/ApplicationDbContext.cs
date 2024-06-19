using Ecclesia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecclesia.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-FI", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }

                );

            modelBuilder.Entity<Product>().HasData(
               new Product 
               { 
                   Id = 1,
                   Title = "Sea", 
                   Description = "Lorem seas at watch the weategres",
                   ISBN = "SWD999999901",
                   ListPrice = 5000,
                   CategoryId = 3,
                   ImageUrl = "sad"
               },
                new Product
                {
                    Id = 2,
                    Title = "Field",
                    Description = "Lorem Fields at watch the weategres loret, toem die . et em Buire",
                    ISBN = "SWD599499201",
                    ListPrice = 8000,
                    CategoryId = 2,
                    ImageUrl = "sada"
                },
                new Product
                {
                    Id = 3,
                    Title = "Mounatin",
                    Description = "Lorem Fields at watch the weategres loret, toem die . et em Buire",
                    ISBN = "SWD5942369201",
                    ListPrice = 18000,
                    CategoryId = 2,
                    ImageUrl = "asdas"
                },
                new Product
                {
                    Id = 4,
                    Title = "Field",
                    Description = "Lorem Fields at watch the weategres loret, toem die . et em Buire",
                    ISBN = "SWD599499201",
                    ListPrice = 8000,
                    CategoryId = 3,
                    ImageUrl = "asdas"
                }


               );
        }
    }
}
