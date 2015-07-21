namespace ContactManager.Migrations
{
    using ContactManager.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.DataContext context)
        {
            Random myRand = new Random();
            List<Contact> contacts = new List<Contact>();

            for (int i = 0; i < 100; i++)
            {
                contacts.Add(myRand.GetRandomContact());
            }

            context.Contacts.AddOrUpdate(c => c.PhoneNumber, contacts.ToArray());
        }
    }
}
