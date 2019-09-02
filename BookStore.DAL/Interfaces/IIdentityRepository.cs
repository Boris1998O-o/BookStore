using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    public interface IIdentityRepository<T> where T:class
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        T Find(string id);
        IEnumerable<T> Find(Func<T, bool> predicate);

        IEnumerable<T> GetAll();
    }
}
