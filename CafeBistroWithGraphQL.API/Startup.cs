using CafeBistroWithGraphQL.API.Data;
using CafeBistroWithGraphQL.API.Interfaces;
using CafeBistroWithGraphQL.API.Mutations;
using CafeBistroWithGraphQL.API.Queries;
using CafeBistroWithGraphQL.API.Schemas;
using CafeBistroWithGraphQL.API.Services;
using CafeBistroWithGraphQL.API.Types;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CafeBistroWithGraphQL.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<ISubMenuService, SubMenuService>();
            services.AddTransient<IReservationService, ReservationService>();

            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();

            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();

            services.AddTransient<MenuMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<RootMutation>();

            services.AddTransient<MenuInputType>();
            services.AddTransient<SubMenuInputType>();
            services.AddTransient<ReservationInputType>();
            services.AddTransient<ISchema, RootSchema>();

            // Only for sample project
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<ProductType>();
            //services.AddTransient<ProductQuery>();
            //services.AddTransient<ProductMutation>();
            //services.AddTransient<ISchema, ProductSchema>();
            // Only for sample project

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            services.AddDbContext<GraphQLDbContext>(option =>
            {
                option.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB; Initial Catalog= CaffeBistroDb; Integrated Security = True;");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQLDbContext graphQLDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
            graphQLDbContext.Database.EnsureCreated();
        }
    }
}
