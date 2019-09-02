using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DAL.Entities
{
    public class StoreRole :IdentityRole
    {
        public StoreRole() : base() { }

        public StoreRole(string name)
            : base(name)
        { }
    }
}
