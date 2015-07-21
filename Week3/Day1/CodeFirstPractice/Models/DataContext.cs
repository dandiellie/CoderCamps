using CodeFirstPractice.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstPractice.Models
{
    public class DataContext : DbContext
    {
        public IDbSet<Restaurant> Restaurants { get; set; }

        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
    }
}