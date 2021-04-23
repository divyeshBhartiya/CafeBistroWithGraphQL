using CafeBistroWithGraphQL.API.Mutations;
using CafeBistroWithGraphQL.API.Queries;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Schemas
{
    public class ProductSchema : Schema
    {
        // Methods
        public ProductSchema(ProductQuery productQuery, ProductMutation productMutation)
        {
            Query = productQuery;
            Mutation = productMutation;
        }
    }

}
