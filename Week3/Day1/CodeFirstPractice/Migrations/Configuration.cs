namespace CodeFirstPractice.Migrations
{
    using CodeFirstPractice.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstPractice.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstPractice.Models.DataContext context)
        {
            Restaurant[] r = new Restaurant[]
            {
                new Restaurant {Name="Red Robin", Description="Burgers", PriceRange="$5-15"},
                new Restaurant {Name="Olive Garden", Description="Italian", PriceRange="$10-20"},
                new Restaurant {Name="Chick-fil-A", Description="Fast Food", PriceRange="$5-10"}
            };

            context.Restaurants.AddOrUpdate(p => p.Name, r);
        }
    }
}
