using BookStore.DAL.Context;
using BookStore.DAL.Entities.Other;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
    public class OrderItemRepository : IRepository<OrderItem>
    {
        private readonly BookStoreContext _bookStoreContext;
        public OrderItemRepository(BookStoreContext bookStoreContext)
        {
            this._bookStoreContext = bookStoreContext;
        }
        public void Create(OrderItem item)
        {
            _bookStoreContext.Add(item);
        }

        public void Delete(OrderItem item)
        {
            _bookStoreContext.Remove(item);
        }

        public OrderItem Find(int? id)
        {
            return _bookStoreContext.OrderItems.Find(id);
        }

        public IEnumerable<OrderItem> Find(Func<OrderItem, bool> predicate)
        {
            return _bookStoreContext.OrderItems.Where(predicate).ToList();
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _bookStoreContext.OrderItems.ToList();
        }

        public void Update(OrderItem item)
        {
            _bookStoreContext.Entry(item).State = EntityState.Modified;
        }
    }
}
