using System.Collections.Generic;

namespace CafeBistroWithGraphQL.API.Models
{
    public class Menu
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<SubMenu> SubMenus { get; set; }
    }
}
