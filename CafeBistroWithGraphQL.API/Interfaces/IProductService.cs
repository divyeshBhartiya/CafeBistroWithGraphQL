using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
