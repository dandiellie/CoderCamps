using AngularServiceMovieLab.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularServiceMovieLab.Controllers.API
{
    public class MoviesController : ApiController
    {
        private static ConcurrentStack<Movie> _movies;

        static MoviesController()
        {
            _movies = new ConcurrentStack<Movie>(new List<Movie>
            {
                new Movie {Title = "Fantastic Four", Year = "2015", Director = "Josh Trank" },
                new Movie {Title = "Ant-Man", Year = "2015", Director = "Peyton Reed" },
                new Movie {Title = "Captain America: Civil War", Year = "2016", Director = "Anthony Russo, Joe Russo" },
                new Movie {Title = "Iron Man 3", Year = "2013", Director = "Shane Black" },
            });
        }

        public IHttpActionResult Get()
        {
            return Ok(_movies);
        }

        public IHttpActionResult Post(Movie movie)
        {
            _movies.Push(movie);
            return Ok();
        }
    }
}
