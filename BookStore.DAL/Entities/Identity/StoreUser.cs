using BookStore.DAL.Entities.Other;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookStore.DAL.Entities
{
    public class StoreUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Order Order { get; set; }
        public override string UserName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                try
                {
                    var tmp = value.Split(" ");
                    FirstName = tmp[0];
                    LastName = tmp[1];
                }
                catch
                {
                    FirstName = value;
                    LastName = string.Empty;
                }
            }
        }
        public async Task<Microsoft.AspNetCore.Identity.IdentityResult> GenerateUserIdentityAsync(Microsoft.AspNetCore.Identity.UserManager<StoreUser> manager)
        {
            var userIdentity = await manager.CreateAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
        public StoreUser():base() { }
        public StoreUser(string name)
            : base(name)
        { }
    }
}