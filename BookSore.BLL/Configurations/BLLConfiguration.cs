using AutoMapper;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Services;
using BookStore.DAL.Configurations;
using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.BLL.Configurations
{
    public class BLLConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddDbContext<BookStoreContext>();
            services.BuildServiceProvider(); 
            //container.GetService<BookStoreContext>();

            services.AddIdentity<StoreUser, StoreRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
            })
    .AddEntityFrameworkStores<BookStoreContext>()
    .AddDefaultTokenProviders();
            DALConfiguration.Configure(services);
            //services.AddAutoMapper();
            
        }

    }
}