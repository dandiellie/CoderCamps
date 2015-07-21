namespace ASPNetMovieDB.Migrations
{
    using ASPNetMovieDB.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetMovieDB.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASPNetMovieDB.Models.DataContext";
        }

        protected override void Seed(ASPNetMovieDB.Models.DataContext context)
        {
            var genres = new Genre[]
            {
                new Genre {Name="SciFi"},
                new Genre {Name="Action"},
                new Genre {Name="Mystery"},
                new Genre {Name="Drama"},
                new Genre {Name="Comedy"},
            };

            context.Genres.AddOrUpdate(g => g.Name, genres);
            context.SaveChanges();
            
            var movies = new Movie[]
            {
                new Movie {Title="Star Wars", Director="George Lucas", GenreId=genres[0].Id},
                new Movie {Title="Memento", Director="Christopher Nolan", GenreId=genres[3].Id},
                new Movie {Title="King Kong", Director="Peter Jackson", GenreId=genres[1].Id}
            };

            context.Movies.AddOrUpdate(p => p.Title, movies);
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
