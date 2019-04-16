using Site_LNU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_LNU.Services
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone 6S",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy Edge",
                        Company = "Samsung",
                        Price = 550
                    },
                    new Phone
                    {
                        Name = "Lumia 950",
                        Company = "Microsoft",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
