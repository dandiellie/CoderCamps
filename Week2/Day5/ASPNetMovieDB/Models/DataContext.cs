using ASPNetMovieDB.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetMovieDB.Models
{
    public class DataContext: DbContext
    {
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Genre> Genres { get; set; }

        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
    }
}