using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuService menuService)
        {
            // Arguments for Mutation
            var menuInput = new QueryArgument<MenuInputType> { Name = nameof(Menu) };
            var menuId = new QueryArgument<IntGraphType> { Name = nameof(Menu.Id) };

            // Add Menu
            Field<MenuType>("createMenu", arguments: new QueryArguments(menuInput),
                resolve: context =>
                {
                    var menu = context.GetArgument<Menu>(nameof(Menu));
                    return menuService.AddMenu(menu);
                });

            // Update Menu
            Field<MenuType>("updateMenu", arguments: new QueryArguments(menuId, menuInput),
                resolve: context =>
                {
                    var menu = context.GetArgument<Menu>(nameof(Menu));
                    var menuId = context.GetArgument<int>(nameof(Menu.Id));
                    return menuService.UpdateMenu(menuId, menu);
                });

            // Delete Menu
            Field<BooleanGraphType>("deleteMenu", arguments: new QueryArguments(menuId),
                resolve: context =>
                {
                    var menuId = context.GetArgument<int>(nameof(Menu.Id));
                    return menuService.DeleteMenu(menuId);
                });
        }
    }
}
