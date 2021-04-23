using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Interfaces
{
    public interface ISubMenuService
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
        SubMenu UpdateMenu(int Id, SubMenu subMenu);
        bool DeleteSubMenu(int Id);
    }
}
