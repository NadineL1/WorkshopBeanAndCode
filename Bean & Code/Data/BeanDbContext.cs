using Microsoft.EntityFrameworkCore;
using Bean___Code.Models;


namespace Bean___Code.Data
{
    public class BeanDbContext : DbContext
    {

        public BeanDbContext(DbContextOptions<BeanDbContext> option) : base(option){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Varma drycker" },
                 new Category { Id = 2, Name = "Kalla drycker" },
                 new Category { Id = 3, Name = "Bakverk" }
              );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Espresso", Description = "En stark italiensk kaffespecialitet", Price = 25M, CategoryId = 1 },
                new Product { Id = 2, Name = "Coffe", Description = "Svart bryggt kaffe", Price = 20M, CategoryId = 1 },
                new Product { Id = 3, Name = "Latte", Description = "Mild kaffedrink med mycket mjölk", Price = 40M, CategoryId = 1 },
                new Product { Id = 4, Name = "Te", Description = "English breakfast", Price = 15M, CategoryId = 1 },
                new Product { Id = 5, Name = "Cheesecake", Description = "En klassiker direkt från New York", Price = 45M, CategoryId = 3 },
                new Product { Id = 6, Name = "Trocadero", Description = "En fruktig och kall svensk ikon", Price = 20, CategoryId = 2 },
                new Product { Id = 7, Name = "Kanelbulle", Description = "Det bästa bakverket", Price = 40M, CategoryId = 3 },
                new Product { Id = 8, Name = "Delicatoboll", Description = "Klassisk fabrikat chokladboll", Price = 25M, CategoryId = 3 }
             );

        }

        public DbSet<Category> Categories {get;set;}

        public DbSet<Product> Products { get; set; }
    }
}
