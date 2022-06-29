using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserTicker> WatchedTickers { get; set; }
    }
}
