//using BookStore.DAL.Context;
//using BookStore.DAL.Entities;
//using BookStore.DAL.Interfaces;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BookStore.DAL.Repositories
//{
//    public class UserRepository : IIdentityRepository<StoreUser>
//    {
//        private readonly BookStoreContext _bookStoreContext;
//        private readonly UserManager<StoreUser> _userManager;
//        public UserRepository(BookStoreContext bookStoreContext, UserManager<StoreUser> userManager)
//        {
//            _bookStoreContext = bookStoreContext;
//            _userManager = userManager;
//        }
//        public void Create(StoreUser item)
//        {
//            _userManager.CreateAsync(item)
//        }

//        public void Delete(StoreUser item)
//        {
//            throw new NotImplementedException();
//        }


//        public IEnumerable<StoreUser> Find(Func<StoreUser, bool> predicate)
//        {
//            throw new NotImplementedException();
//        }

//        public StoreUser Find(string id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<StoreUser> GetAll()
//        {
//            throw new NotImplementedException();
//        }


//        public void Update(StoreUser item)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
