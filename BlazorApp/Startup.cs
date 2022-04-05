using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp.Data;
using SpeeDine.Backend.Repositories;
using SpeeDine.Backend.Models;
using Blazored.Toast;

namespace BlazorApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            // Add dependencies
            services.AddSingleton<MenuRepository>();
            var user1 = new User(1, "Guest 1");
            var user2 = new User(2, "Guest 2");
            services.AddSingleton<User>(user1);
            List<User> users = new List<User> { user1, user2 };
            var table = new Table(users);
            services.AddSingleton<Table>(table);

            var menuRepo = new MenuRepository();
            var user2Food = new OrderItem(1,menuRepo.GetItemByID(1), 2, OrderStatus.PendingOrder, null, null);
            var user2Drink = new OrderItem(2,menuRepo.GetItemByID(2), 1, OrderStatus.PendingOrder, null, "Medium well, please");
            user2.Cart = new List<OrderItem> { user2Food, user2Drink };

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
