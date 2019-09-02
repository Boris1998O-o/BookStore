using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DAL.Interfaces
{
    public interface IRepository<T> where T:class
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        T Find(int? id);
        IEnumerable<T> Find(Func<T, bool> predicate);

        IEnumerable<T> GetAll();
    }
}
