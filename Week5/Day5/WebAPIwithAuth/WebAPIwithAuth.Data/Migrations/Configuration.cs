namespace WebAPIwithAuth.Data.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIwithAuth.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAPIwithAuth.Data.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            var dani = userManager.FindByName("dani@gmail.com");

            if(dani == null)
            {
                dani = new ApplicationUser
                {
                    UserName = "dani@gmail.com",
                    Email = "dani@gmail.com"
                };

                userManager.Create(dani, "123456");
                dani = userManager.FindByName("dani@gmail.com");
            }

            var alton = userManager.FindByName("alton@gmail.com");

            if (alton == null)
            {
                alton = new ApplicationUser
                {
                    UserName = "alton@gmail.com",
                    Email = "alton@gmail.com"
                };

                userManager.Create(alton, "123456");
                alton = userManager.FindByName("alton@gmail.com");
            }

            Car[] cars = new Car[]
            {
                new Car {Make = "Ferrari", Model="California", Color="Red", IsBadAss=true, Price=200000m, UserId=alton.Id},
                new Car {Make = "Porche", Model="911 Turbo S", Color="Silver", IsBadAss=true, Price=190000m, UserId=dani.Id },
                new Car {Make = "Toyota", Model="Prius", Color="Green", IsBadAss=false, Price=35000m, UserId=dani.Id },
                new Car {Make = "Chevy", Model="El Camino", Color="Pink", IsBadAss=false, Price=7000m, UserId=alton.Id }
            };

            context.Cars.AddOrUpdate(c => c.Model, cars);
        }
    }
}
