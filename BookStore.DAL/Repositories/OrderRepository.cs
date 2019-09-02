using BookStore.DAL.Context;
using BookStore.DAL.Entities.Other;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.DAL.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BookStoreContext _bookStoreContext;
        public OrderRepository(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }
        public void Create(Order item)
        {
            _bookStoreContext.Orders.Add(item);
        }

        public void Delete(Order item)
        {
            _bookStoreContext.Orders.Remove(item);
        }


        public Order Find(int? id)
        {
            return _bookStoreContext.Orders.Find(id);
        }

        public IEnumerable<Order> Find(Func<Order, bool> predicate)
        {
            return _bookStoreContext.Orders.Where(predicate).ToList();
        }

        public IEnumerable<Order> GetAll()
        {
            return _bookStoreContext.Orders.ToList();
        }


        public void Update(Order item)
        {
            _bookStoreContext.Entry(item).State = EntityState.Modified;
        }
    }
}
