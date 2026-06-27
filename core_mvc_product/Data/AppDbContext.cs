using core_mvc_product.Models;
using Microsoft.EntityFrameworkCore;

namespace core_mvc_product.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
    }
}
