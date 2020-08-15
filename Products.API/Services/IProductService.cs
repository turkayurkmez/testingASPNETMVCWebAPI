using Products.API.Models;
using System.Collections.Generic;

namespace Products.API.Services
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
