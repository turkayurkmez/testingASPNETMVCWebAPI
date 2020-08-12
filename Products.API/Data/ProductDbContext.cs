using Microsoft.EntityFrameworkCore;
using Products.API.Models;

namespace Products.API.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }



    }
}
