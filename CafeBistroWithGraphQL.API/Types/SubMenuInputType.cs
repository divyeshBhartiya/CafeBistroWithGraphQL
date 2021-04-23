using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>(nameof(SubMenu.Id));
            Field<StringGraphType>(nameof(SubMenu.Name));
            Field<StringGraphType>(nameof(SubMenu.ImageUrl));
            Field<StringGraphType>(nameof(SubMenu.Description));
            Field<FloatGraphType>(nameof(SubMenu.Price));
            Field<IntGraphType>(nameof(SubMenu.MenuId));
        }
    }
}
