using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence.Migrations
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Avtivity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description ="Activity 2 months ago",
                    Category ="Drinks",
                    City = "London",
                    Venue ="Pub"
                },
                new Activity
                {
                    Title = "Past Avtivity 2",
                    Date = DateTime.Now.AddMonths(-2),
                    Description ="Activity 2 months ago",
                    Category ="Drinks",
                    City = "Rome",
                    Venue ="Pub"
                }
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}