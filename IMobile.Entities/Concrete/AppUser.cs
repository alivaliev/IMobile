using IMobile.Core.Entities.Abstract;
using IMobile.Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.Concrete
{
    public class AppUser : IdentityUser , IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
