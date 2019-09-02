using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace BookStore.DAL.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly BookStoreContext _bookStoreContext;
        public AuthorRepository(BookStoreContext bookStoreContext)
        {
            this._bookStoreContext = bookStoreContext;
        }

        public void Create(Author item)
        {
            _bookStoreContext.Authors.Add(item);
        }

        public void Delete(Author item)
        {
            _bookStoreContext.Authors.Remove(item);
        }

        public Author Find(int? id)
        {
            return _bookStoreContext.Authors.Find(id);
        }


        public IEnumerable<Author> Find(Func<Author, bool> predicate)
        {
            var returned = _bookStoreContext.Authors.Where(predicate).ToList();
            return returned;
        }

        public IEnumerable<Author> GetAll()
        {
            return _bookStoreContext.Authors.ToList();
        }

        public void Save()
        {
            _bookStoreContext.SaveChanges();
        }

        public void Update(Author item)
        {
            _bookStoreContext.Entry(item).State = EntityState.Modified;
        }
    }
}