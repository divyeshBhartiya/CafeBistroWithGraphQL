using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenuService subMenuService)
        {
            // Arguments for Mutation
            var subMenuInput = new QueryArgument<SubMenuInputType> { Name = nameof(SubMenu) };
            var subMenuId = new QueryArgument<IntGraphType> { Name = nameof(SubMenu.Id) };

            // Add SubMenu
            Field<SubMenuType>("createSubMenu", arguments: new QueryArguments(subMenuInput),
             resolve: context =>
             {
                 return subMenuService.AddSubMenu(context.GetArgument<SubMenu>(nameof(SubMenu)));
             });

            // Update SubMenu
            Field<SubMenuType>("updateSubMenu", arguments: new QueryArguments(subMenuId, subMenuInput),
                resolve: context =>
                {
                    var subMenu = context.GetArgument<SubMenu>(nameof(SubMenu));
                    var subMenuId = context.GetArgument<int>(nameof(SubMenu.Id));
                    return subMenuService.UpdateSubMenu(subMenuId, subMenu);
                });

            // Delete SubMenu
            Field<BooleanGraphType>("deleteSubMenu", arguments: new QueryArguments(subMenuId),
                resolve: context =>
                {
                    var subMenuId = context.GetArgument<int>(nameof(SubMenu.Id));
                    return subMenuService.DeleteSubMenu(subMenuId);
                });
        }
    }
}
