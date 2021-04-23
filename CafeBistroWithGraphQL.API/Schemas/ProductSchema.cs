using CafeBistroWithGraphQL.API.Mutations;
using CafeBistroWithGraphQL.API.Queries;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
