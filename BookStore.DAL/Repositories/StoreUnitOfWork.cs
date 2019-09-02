using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Entities.Other;
using BookStore.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    class StoreUnitOfWork : IUnitOfWork
    {
        private readonly BookStoreContext _bookStoreContext;
        private AuthorRepository authorRepository;
        private OrderRepository orderRepository;
        private PaymentRepository _paymentRepository;
        private PrintingEditionRepository printingEditionRepository;
        private OrderItemRepository orderItemRepository;
        private UserManager<StoreUser> _userManager;
        private RoleManager<StoreRole> _roleManager;


        public StoreUnitOfWork(UserManager<StoreUser> userManager, RoleManager<StoreRole> roleManager)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookStoreContext>();

            var options = optionsBuilder
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;")
                    .Options;


            _bookStoreContext = new BookStoreContext(options);
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void InitializeDataBase()
        {
            var initializer = new DataInitializer(_userManager, _roleManager, _bookStoreContext);
            initializer.Initialize();
        }

        public StoreUnitOfWork()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookStoreContext>();

            var options = optionsBuilder
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;")
                    .Options;


            _bookStoreContext = new BookStoreContext(options);
        }

        public UserManager<StoreUser> AppUserManager
        {
            get { return _userManager; }
        }

        public RoleManager<StoreRole> AppRoleManager
            {
            get { return _roleManager; }
            }

        public IRepository<Author> Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(_bookStoreContext);
                return authorRepository;
            }
        }


        public IRepository<Payment> Payments
        {
            get
            {
                if (_paymentRepository == null)
                    _paymentRepository = new PaymentRepository(_bookStoreContext);
                return _paymentRepository;
            }
        }

        public IRepository<PrintingEdition> PrintingEditions
        {
            get
            {
                if (printingEditionRepository == null)
                    printingEditionRepository = new PrintingEditionRepository(_bookStoreContext);
                return printingEditionRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(_bookStoreContext);
                return orderRepository;
            }
        }

        public IRepository<OrderItem> OrderItems
            {
            get
            {
                if (orderItemRepository == null)
                    orderItemRepository = new OrderItemRepository(_bookStoreContext);
                return orderItemRepository;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                //if (disposing)
                //{
                //    UserManager..Dispose();
                //    RoleManager.Dispose();
                //}
                this.disposed = true;
            }
        }

        public Task SaveAsync()
        {
            return _bookStoreContext.SaveChangesAsync();
        }
    }
}
