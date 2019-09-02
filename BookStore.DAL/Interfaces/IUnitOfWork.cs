using BookStore.DAL.Entities;
using BookStore.DAL.Entities.Other;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Author> Authors { get; }
        IRepository<Payment> Payments { get; }
        IRepository<PrintingEdition> PrintingEditions { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        void InitializeDataBase();
        Task SaveAsync();
        void Dispose();
    }
}
