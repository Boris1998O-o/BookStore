//using BookStore.DAL.Context;
//using BookStore.DAL.Entities;
//using BookStore.DAL.Interfaces;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStore.DAL.Repositories
//{
//    public class RoleRepository : IIdentityRepository<StoreRole>
//    {
//        private readonly BookStoreContext _bookStoreContext;
//        private readonly RoleManager<StoreUser> _roleManager;
//        public RoleRepository(BookStoreContext bookStoreContext, RoleManager<StoreUser> roleManager)
//        {
//            _bookStoreContext = bookStoreContext;
//            _roleManager = roleManager;
//        }
//        public void Create(StoreRole item)
//        {
//            _bookStoreContext.Remove(item);
//        }

//        public void Delete(StoreRole item)
//        {
//            _bookStoreContext.Roles.Remove(item);
//        }

//        public StoreRole Find(string id)
//        {
//            var returned = _bookStoreContext.Roles.Find(id);
//            return returned;
//        }

//        public IEnumerable<StoreRole> Find(Func<StoreRole, bool> predicate)
//        {
//            return _bookStoreContext.Roles.Where(predicate).ToList();
//        }

//        public IEnumerable<StoreRole> GetAll()
//        {
//            return _bookStoreContext.Roles.ToList();
//        }


//        public void Update(StoreRole item)
//        {
//            _bookStoreContext.Entry(item).State = EntityState.Modified;
//        }
//    }
//}