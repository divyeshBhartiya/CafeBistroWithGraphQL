using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Mutations
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductService productService)
        {
            // Arguments for Mutation
            var productInput = new QueryArgument<ProductInputType> { Name = nameof(Product) };
            var productId = new QueryArgument<IntGraphType> { Name = nameof(Product.Id) };

            // Add Product
            Field<ProductType>("createProduct", arguments: new QueryArguments(productInput),
                resolve: context =>
                {
                    var product = context.GetArgument<Product>(nameof(Product));
                    return productService.AddProduct(product);
                });

            // Update Product
            Field<ProductType>("updateProduct", arguments: new QueryArguments(productId, productInput),
                resolve: context =>
                {
                    var product = context.GetArgument<Product>(nameof(Product));
                    var productId = context.GetArgument<int>(nameof(Product.Id));
                    return productService.UpdateProduct(productId, product);
                });

            // Delete Product
            Field<BooleanGraphType>("deleteProduct", arguments: new QueryArguments(productId),
                resolve: context =>
                {
                    var productId = context.GetArgument<int>(nameof(Product.Id));
                    return productService.DeleteProduct(productId);
                });
        }
    }
}
