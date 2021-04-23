using CafeBistroWithGraphQL.API.Models;
using System.Collections.Generic;

namespace CafeBistroWithGraphQL.API.Interfaces
{
    public interface ISubMenuService
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
        SubMenu UpdateSubMenu(int Id, SubMenu subMenu);
        bool DeleteSubMenu(int Id);
    }
}
