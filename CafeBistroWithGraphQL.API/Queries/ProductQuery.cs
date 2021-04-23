using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Queries
{
    public class ProductQuery : ObjectGraphType
    {
        // Methods
        public ProductQuery(IProductService productService)
        {
            Field<ListGraphType<ProductType>>("products", resolve: context => { return productService.GetAllProducts(); });

            var productId = new QueryArgument<IntGraphType> { Name = nameof(Product.Id) };
            Field<ProductType>("product", arguments: new QueryArguments(productId),
                resolve: context =>
                {
                    return productService.GetProductById(context.GetArgument<int>(nameof(Product.Id)));
                });
        }

    }

}
