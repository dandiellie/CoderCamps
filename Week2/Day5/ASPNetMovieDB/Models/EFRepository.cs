using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetMovieDB.Models
{
    /// <summary>
    /// Provides CRUD operations for Movies
    /// </summary>
    public class EFRepository : IDisposable, IRepository
    {
        private DataContext _db = new DataContext();

        /// <summary>
        /// Retrieve all movies.
        /// </summary>
        public IList<Movie> ListMovies()
        {
            return _db.Movies.ToList();
        }

        /// <summary>
        /// Find movie by primary key.
        /// </summary>
        /// <param name="id">primary key</param>
        public Movie FindMovie(int id)
        {
            return _db.Movies.Find(id);
        }

        /// <summary>
        /// Add new movie to db.
        /// </summary>
        /// <param name="movieToCreate"></param>
        public void CreateMovie(Movie movieToCreate)
        {
            _db.Movies.Add(movieToCreate);
            _db.SaveChanges();
        }


        /// <summary>
        /// Update existing movie in database.
        /// </summary>
        /// <param name="movieToUpdate"></param>
        public void UpdateMovie(Movie movieToUpdate)
        {
            var originalMovie = this.FindMovie(movieToUpdate.Id);
            originalMovie.Title = movieToUpdate.Title;
            originalMovie.Director = movieToUpdate.Director;
            _db.SaveChanges();
        }

        /// <summary>
        /// Delete existing movie.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteMovie(int id)
        {
            var originalMovie = this.FindMovie(id);
            _db.Movies.Remove(originalMovie);
            _db.SaveChanges();
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}