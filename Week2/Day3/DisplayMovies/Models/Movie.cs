using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayMovies.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string RunTime { get; set; }
    }
}