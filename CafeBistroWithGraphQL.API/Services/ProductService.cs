using CafeBistroWithGraphQL.API.Data;
using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Services
{
    public class ProductService : IProductService
    {
        private GraphQLDbContext _dbContext;
        public ProductService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }
        public Product UpdateProduct(int id, Product product)
        {
            var productObj = _dbContext.Products.Find(id);
            productObj.Name = product.Name;
            productObj.Price = product.Price;

            _dbContext.SaveChanges();
            return product;
        }
        public bool DeleteProduct(int id)
        {
            try
            {
                var productObj = _dbContext.Products.Find(id);
                _dbContext.Products.Remove(productObj);

                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
