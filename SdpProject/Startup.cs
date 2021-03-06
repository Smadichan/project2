using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SdpProject.Database;
using SdpProject.Interfaces;
using SdpProject.Mocks;
using SdpProject.Repository;

namespace SdpProject
{
    public class Startup
    {
        private IConfigurationRoot _confString;

       public Startup(IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();

        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your  application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<InterfaceAllDishes, DishRepository>();
            services.AddTransient<InterfaceCategoryDishes, CategoryRepository>();

            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
                app.UseStaticFiles();
                app.UseMvcWithDefaultRoute();
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                    DBObjects.Initital(content);

                }



            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "calculator",
                    template: "{controller=Login}/Login");


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Hello}/{action=Index}/{id?}");
            });
        }
    }
}
