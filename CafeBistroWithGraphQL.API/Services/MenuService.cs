using CafeBistroWithGraphQL.API.Data;
using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace CafeBistroWithGraphQL.API.Services
{
    public class MenuService : IMenuService
    {
        private GraphQLDbContext _graphQLDbContext;
        public MenuService(GraphQLDbContext graphQLDbContext)
        {
            _graphQLDbContext = graphQLDbContext;
        }

        public List<Menu> GetMenus()
        {
            return _graphQLDbContext.Menus.ToList();
        }
        public Menu AddMenu(Menu menu)
        {
            _graphQLDbContext.Menus.Add(menu);
            _graphQLDbContext.SaveChanges();
            return menu;
        }
        public Menu UpdateMenu(int menuId, Menu menu)
        {
            var menuObj = _graphQLDbContext.Menus.Find(menuId);
            menuObj.Name = menu.Name;
            menuObj.ImageUrl = menu.ImageUrl;

            _graphQLDbContext.SaveChanges();
            return menu;
        }
        public bool DeleteMenu(int menuId)
        {
            try
            {
                var menuObj = _graphQLDbContext.Menus.Find(menuId);
                _graphQLDbContext.Menus.Remove(menuObj);

                _graphQLDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
