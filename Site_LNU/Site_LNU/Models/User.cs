using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_LNU.Models
{
    public class User : IdentityUser
    {
        public int SumOfMoney { get; set; }
    }
}
