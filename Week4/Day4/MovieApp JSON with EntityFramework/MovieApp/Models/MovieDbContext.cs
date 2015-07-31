using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MovieDbContext : DbContext
    {
        public IDbSet<Movie> Movies { get; set; }
    }
}