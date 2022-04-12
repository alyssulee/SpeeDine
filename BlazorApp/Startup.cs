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
using Blazored.Modal;

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
            services.AddBlazoredToast();
            services.AddBlazoredModal();

            // Add dependencies
            services.AddSingleton<MenuRepository>();
            var user1 = new User(1, "Alice");
            var user2 = new User(2, "Bob");
            services.AddSingleton<User>(user1);
            List<User> users = new List<User> { user1, user2 };
            var table = new Table(users);
            services.AddSingleton<Table>(table);

            var menuRepo = new MenuRepository();
            var user2Food = new OrderItem(1,menuRepo.GetItemByID(18), 1, OrderStatus.PendingOrder, null, null);
            var user2Drink = new OrderItem(2,menuRepo.GetItemByID(16), 1, OrderStatus.PendingOrder, null, null);
            user2.Cart = new List<OrderItem> { user2Food, user2Drink };

            //var user1Food = new OrderItem(11, menuRepo.GetItemByID(1), 1, OrderStatus.Delivered, menuRepo.GetItemByID(1).Sides[4], "No mayo please!");
            //var user1Drink = new OrderItem(22, menuRepo.GetItemByID(30), 3, OrderStatus.Delivered, null, null);
            //user1.Orders = new List<OrderItem> { user1Food, user1Drink }
            //user1.Orders = new List<OrderItem> { user1Food };

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
