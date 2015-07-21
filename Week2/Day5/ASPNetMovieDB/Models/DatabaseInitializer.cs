using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetMovieDB.Models
{
    public class DatabaseInitializer: DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {Title = "Star Wars", Director = "Lucas"},
                new Movie {Title = "Momento", Director = "Nolan"},
                new Movie {Title = "King Kong", Director = "Jackson"}
            };

            movies.ForEach(m => context.Movies.Add(m));
        }
    }
}