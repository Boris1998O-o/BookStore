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
    class PaymentRepository : IRepository<Payment>
    {
        private readonly BookStoreContext _bookStoreContext;
        public PaymentRepository(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }
        public void Create(Payment item)
        {
            _bookStoreContext.Payments.Add(item);
        }

        public void Delete(Payment item)
        {
            _bookStoreContext.Payments.Remove(item);
        }

        public Payment Find(int? id)
        {
            return _bookStoreContext.Payments.Find(id);
        }

        public IEnumerable<Payment> Find(Func<Payment, bool> predicate)
        {
            return _bookStoreContext.Payments.Where(predicate).ToList();
        }

        public IEnumerable<Payment> GetAll()
        {
            return _bookStoreContext.Payments.ToList();
        }


        public void Update(Payment item)
        {
            _bookStoreContext.Entry(item).State = EntityState.Modified;
        }
    }
}
