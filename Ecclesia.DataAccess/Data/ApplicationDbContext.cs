using Ecclesia.Models;
using Microsoft.EntityFrameworkCore;


namespace Ecclesia.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
<<<<<<< Updated upstream
=======
        public DbSet<Product> Products{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public DbSet<OrderHeader> OrderHeaders{ get; set; }
        public DbSet<OrderDetail> OrderDetails{ get; set; }
>>>>>>> Stashed changes

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-FI", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }

                );
        }
    }
}
