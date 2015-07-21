using ContactManager.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class DataContext : DbContext
    {
        public IDbSet<Contact> Contacts { get; set; }

        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
    }
}