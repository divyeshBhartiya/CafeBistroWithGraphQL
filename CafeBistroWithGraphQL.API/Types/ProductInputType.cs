using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>(nameof(Product.Id));
            Field<StringGraphType>(nameof(Product.Name));
            Field<FloatGraphType>(nameof(Product.Price));
        }
    }
}
