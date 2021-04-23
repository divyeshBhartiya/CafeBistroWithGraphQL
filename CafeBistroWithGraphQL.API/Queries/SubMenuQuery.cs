using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using CafeBistroWithGraphQL.API.Types;
using GraphQL;
using GraphQL.Types;

namespace CafeBistroWithGraphQL.API.Queries
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenuService subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("subMenus", resolve: context => { return subMenuService.GetSubMenus(); });

            var subMenuId = new QueryArgument<IntGraphType> { Name = nameof(SubMenu.Id) };
            Field<ListGraphType<SubMenuType>>("subMenuById", arguments: new QueryArguments(subMenuId),
              resolve: context =>
              {
                  return subMenuService.GetSubMenus(context.GetArgument<int>(nameof(SubMenu.Id)));
              });
        }
    }
}
