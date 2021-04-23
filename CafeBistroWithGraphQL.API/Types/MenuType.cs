using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Types
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenuService subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => 
            { 
                return subMenuService.GetSubMenus(context.Source.Id); 
            });
        }
    }
}
