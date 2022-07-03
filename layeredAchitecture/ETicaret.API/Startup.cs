
using ETicaret.BusinessLayer.Abstract;
using ETicaret.BusinessLayer.Concrete;
using ETicaret.DataAccessLayer;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ETicaret.API
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
            services.AddControllers();

            services.AddSingleton<IFavoriteRepository, FavoriteRepository>();
            services.AddSingleton<IOrderRepository, OrderRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IAddressRepository, AddressRepository>();
            services.AddSingleton<IProductRepository, ProductRepository>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IOrderService, OrderManager>();
            services.AddSingleton<IFavoriteService, FavoriteManager>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IAddressService, AddressManager>();
            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
