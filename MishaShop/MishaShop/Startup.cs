using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MishaShop.Models;

namespace MishaShop
{
    /// <summary>
    /// Class with logic of pipeline
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Basic configuration prop what stores all provided configurations
        /// </summary>
        public IConfiguration Configuration { get; set; }
        public ILoggerFactory LoggerFactory { get; set; }

        /// <summary>
        /// Ctop to get configurations
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            LoggerFactory = loggerFactory;
        }

        /// <summary>
        /// Main DI method
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
            })
            .AddEntityFrameworkStores<CustomerContext>();
            services.AddDbContext<CustomerContext>(options => options.UseMySql(connection));
            services.AddRazorPages();
            services.AddControllersWithViews();
        }

        /// <summary>
        /// Request handling pipeline method
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // default route in MishaShop application
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller}/{Action}",
                    defaults: new { Controller = "HomePage", Action = "Index" });
            });
        }
    }
}
