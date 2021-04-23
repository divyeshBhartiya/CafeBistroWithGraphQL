using CafeBistroWithGraphQL.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeBistroWithGraphQL.API.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
