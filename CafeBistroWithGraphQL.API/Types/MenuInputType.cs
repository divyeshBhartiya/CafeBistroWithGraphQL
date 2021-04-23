using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>(nameof(Menu.Id));
            Field<StringGraphType>(nameof(Menu.Name));
            Field<StringGraphType>(nameof(Menu.ImageUrl));
        }
    }
}
