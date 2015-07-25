namespace ASPNetIdentityDemo.Migrations
{
    using ASPNetIdentityDemo.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            // 1. Seed Roles
            if (!roleManager.RoleExists("Admin")) roleManager.Create(new Role { Name = "Admin" });
            if (!roleManager.RoleExists("General")) roleManager.Create(new Role { Name = "General" });

            // 2. Seed Users
            ApplicationUser dani = userManager.FindByEmail("dani@codercamps.com");

            if (dani == null)
            {
                dani = new ApplicationUser
                {
                    UserName = "dani@codercamps.com",
                    Email = "dani@codercamps.com"
                };

                userManager.Create(dani, "123456");
                dani = userManager.FindByEmail("dani@codercamps.com");

                userManager.AddToRole(dani.Id, "Admin");
            }

            userManager.AddClaim(dani.Id, new Claim("CanEditProducts", "true"));
        }
    }
}
