using CafeBistroWithGraphQL.API.Models;
using System.Collections.Generic;

namespace CafeBistroWithGraphQL.API.Interfaces
{
    public interface IProductService
    {
        // Methods
        Product AddProduct(Product product);
        bool DeleteProduct(int id);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(int id, Product product);
    }


}
