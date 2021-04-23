using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.ImageUrl);
            Field(m => m.Price);
            Field(m => m.MenuId);
        }
    }
}
