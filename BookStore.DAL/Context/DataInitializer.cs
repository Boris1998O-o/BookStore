using BookStore.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.DAL.Context
{
    public class DataInitializer
    {
        private UserManager<StoreUser> _userManager;
        private RoleManager<StoreRole> _roleManager;
        private BookStoreContext _bookStoreContext;

        public DataInitializer(UserManager<StoreUser> userManager, RoleManager<StoreRole> roleManager, BookStoreContext bookStoreContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _bookStoreContext = bookStoreContext;
        }

        public  void Initialize()
        {
            if (_bookStoreContext.Users.Any() && _bookStoreContext.Roles.Any())
            {
                var adminRole = new StoreRole("Admin");
                var userRole = new StoreRole("User");
                _roleManager.CreateAsync(adminRole);
                _roleManager.CreateAsync(userRole);

                var admin = new StoreUser("Main admin");
                var adminPassword = "adminPassword";
                _userManager.AddToRoleAsync(admin, adminRole.Name);
                _userManager.CreateAsync(admin, adminPassword);
            }
            if (_bookStoreContext.Authors.Any() && !_bookStoreContext.PrintingEditions.Any())
            {
                var dostoevskyiBook1 = new PrintingEdition()
                {
                    CreationData = DateTime.Parse("24 05 1933"),
                    Currency = Entities.Enums.Currency.USD,
                    Description = "Most boring book ever",
                    Name = "Crime and punishment",
                    Price = 7,
                    IsRemoved = false,
                    Type = Entities.Enums.EditionType.Book
                };
                var dostoevskiyBook2 = new PrintingEdition()
                {
                    CreationData = DateTime.Parse("24 05 1678"),
                    Currency = Entities.Enums.Currency.USD,
                    Description = "Better then LSD",
                    Name = "Karamazow brothers",
                    Price = 44,
                    IsRemoved = false,
                    Type = Entities.Enums.EditionType.Book                };

                var dostoevskyiBooks = new List<PrintingEdition>();
                dostoevskyiBooks.Add(dostoevskyiBook1);
                dostoevskyiBooks.Add(dostoevskiyBook2);
                _bookStoreContext.PrintingEditions.Add(dostoevskyiBook1);
                _bookStoreContext.PrintingEditions.Add(dostoevskiyBook2);
                
                var dostoevskyy = new Author() { Name = "Dostoevskyi", IsRemoved = false, PrintingEditions = dostoevskyiBooks };
                _bookStoreContext.Authors.Add(dostoevskyy);
            }
            _bookStoreContext.SaveChanges();
        }
    }
}