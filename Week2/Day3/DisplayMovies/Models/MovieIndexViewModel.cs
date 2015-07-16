using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayMovies.Models
{
    public class MovieIndexViewModel
    {
        public List<Movie> MovieLibrary { get; set; }
        public int numMovies { get; set; }

        public MovieIndexViewModel()
        {
            MovieLibrary = new List<Movie>
            {
                new Movie
                {
                    Name = "The Fellowship of the Ring",
                    Director = "Peter Jackson",
                    Year = 2001,
                    RunTime = "178 min"
                },
                new Movie
                {
                    Name = "The Sorcerer's Stone",
                    Director = "Chris Columbus",
                    Year = 2001,
                    RunTime = "152 min"
                },
                new Movie
                {
                    Name = "Iron Man",
                    Director = "Jon Favreau",
                    Year = 2008,
                    RunTime = "126 min"
                }
            };
        }
    }
}