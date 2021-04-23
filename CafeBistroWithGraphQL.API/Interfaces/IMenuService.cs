using CafeBistroWithGraphQL.API.Models;
using System.Collections.Generic;

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
