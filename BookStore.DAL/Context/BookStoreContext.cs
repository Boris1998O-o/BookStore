using BookStore.DAL.Entities;
using BookStore.DAL.Entities.Other;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BookStore.DAL.Context
{
    public class BookStoreContext : IdentityDbContext<StoreUser, StoreRole, string>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PrintingEdition> PrintingEditions { get; set; }
        public DbSet<OrderItem> OrderItems { set; get; }
        public DbSet<Payment> Payments { get; set; }


        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
            
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
