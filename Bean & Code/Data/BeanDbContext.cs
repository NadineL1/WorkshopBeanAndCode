using Microsoft.EntityFrameworkCore;
using Bean___Code.Models;


namespace Bean___Code.Data
{
    public class BeanDbContext : DbContext
    {

        public BeanDbContext(DbContextOptions<BeanDbContext> option) : base(option)
        {

        }

        public DbSet<Category> Categories {get;set;}

        public DbSet<Product> Products { get; set; }
    }
}
