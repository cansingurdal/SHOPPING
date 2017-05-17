﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SHOPPING.Bussiness.Abstract;
using SHOPPING.Bussiness.Concrete;
using SHOPPING.DataAccess.Abstract;
using SHOPPING.DataAccess.Concrete.EntityFramework;
using SHOPPING.MvcCoreUI.Entities;
using SHOPPING.MvcCoreUI.Middlewares;
using SHOPPING.MvcCoreUI.Services;

namespace SHOPPING.MvcCoreUI
{
    public class Startup
    {
            // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddScoped<IProductService, ProductManager>();
                services.AddScoped<IProductDal, EfProductDal>();
                services.AddScoped<ICategoryService, CategoryManager>();
                services.AddScoped<ICategoryDal, EfCategoryDal>();
                services.AddSingleton<ICartSessionService, CartSessionService>();
                services.AddScoped<ICartService, CartService>();
                services.AddDbContext<CustomIdentityDbContext>
                    (options => options.UseSqlServer("Server=.;Database=SHOPPING;Trusted_Connection=true"));
                services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                    .AddEntityFrameworkStores<CustomIdentityDbContext>()
                    .AddDefaultTokenProviders();
                services.AddMvc();
                services.AddSession();
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                services.AddDistributedMemoryCache();

            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseFileServer();
                app.UseNodeModules(env.ContentRootPath);
                app.UseIdentity();
                app.UseSession();
                app.UseMvc(ConfigureRoutes);

            }

            private void ConfigureRoutes(IRouteBuilder routeBuilder)
            {
                //Home/Index
                routeBuilder.MapRoute("Default", "{controller=Product}/{action=Index}/{id?}");
            }
        }
    }
