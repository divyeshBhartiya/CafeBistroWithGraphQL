using CafeBistroWithGraphQL.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeBistroWithGraphQL.API.Interfaces
{
    public interface IMenuService
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(int Id, Menu menu);
        bool DeleteMenu(int Id);
    }
}
