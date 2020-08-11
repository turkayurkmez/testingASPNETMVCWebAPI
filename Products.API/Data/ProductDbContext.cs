using Microsoft.EntityFrameworkCore;
using TestAPIUsingWebApplicationFactory.Models;

namespace TestAPIUsingWebApplicationFactory.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }



    }
}
