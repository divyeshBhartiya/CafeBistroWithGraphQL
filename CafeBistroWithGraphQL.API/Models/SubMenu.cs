namespace CafeBistroWithGraphQL.API.Models
{
    public class SubMenu
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int MenuId { get; set; }
    }
}
