using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Repositories
{
    class PrintingEditionRepository : IRepository<PrintingEdition>
    {
        private readonly BookStoreContext _bookStoreContext;
        public PrintingEditionRepository(BookStoreContext bookStoreContext)
        {
            this._bookStoreContext = bookStoreContext;
        }
        public void Create(PrintingEdition item)
        {
            _bookStoreContext.PrintingEditions.Add(item);
        }

        public void Delete(PrintingEdition item)
        {
            _bookStoreContext.PrintingEditions.Remove(item);
        }


        public PrintingEdition Find(int? id)
        {
            return _bookStoreContext.PrintingEditions.Find(id);
        }

        public IEnumerable<PrintingEdition> Find(Func<PrintingEdition, bool> predicate)
        {
            return _bookStoreContext.PrintingEditions.Where(predicate).ToList();
        }

        public IEnumerable<PrintingEdition> GetAll()
        {
            return _bookStoreContext.PrintingEditions.ToList();
        }


        public void Update(PrintingEdition item)
        {
            _bookStoreContext.Entry(item).State = EntityState.Modified;
        }
    }
}
