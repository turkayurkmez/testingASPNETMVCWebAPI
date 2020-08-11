using System.Collections.Generic;
using TestAPIUsingWebApplicationFactory.Models;

namespace TestAPIUsingWebApplicationFactory.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        Product Add(Product product);
        Product Edit(Product product);
        Product Delete(int id);


    }
}
