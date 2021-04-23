using CafeBistroWithGraphQL.API.Data;
using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Services
{
    public class SubMenuService : ISubMenuService
    {
        private GraphQLDbContext _graphQLDbContext;
        public SubMenuService(GraphQLDbContext graphQLDbContext)
        {
            _graphQLDbContext = graphQLDbContext;
        }

        public List<SubMenu> GetSubMenus()
        {
            return _graphQLDbContext.SubMenus.ToList();
        }
        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _graphQLDbContext.SubMenus.Where(m => m.MenuId == menuId).ToList();
        }
        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _graphQLDbContext.SubMenus.Add(subMenu);
            _graphQLDbContext.SaveChanges();
            return subMenu;
        }
        public SubMenu UpdateMenu(int subMenuId, SubMenu subMenu)
        {
            var subMenuObj = _graphQLDbContext.SubMenus.Find(subMenuId);
            subMenuObj.Name = subMenu.Name;
            subMenuObj.MenuId = subMenu.MenuId;
            subMenuObj.Price = subMenu.Price;
            subMenuObj.Description = subMenu.Description;
            subMenuObj.ImageUrl = subMenu.ImageUrl;

            _graphQLDbContext.SaveChanges();
            return subMenu;
        }
        public bool DeleteSubMenu(int subMenuId)
        {
            try
            {
                var subMenuObj = _graphQLDbContext.SubMenus.Find(subMenuId);
                _graphQLDbContext.SubMenus.Remove(subMenuObj);

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
