using FoodBank.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBank.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FoodBankContext(
                serviceProvider.GetRequiredService<DbContextOptions<FoodBankContext>>()))
            {
                // Look for any movies.
                if (context.FoodItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.FoodItem.AddRange(
                    new FoodItem
                    {
                        Calories = 301,
                        Id = 1997,
                        Item_Name = "Taco",
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
