using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Types;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Queries
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuService menuService)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => { return menuService.GetMenus(); });
        }
    }
}
