using ASPNetMovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetMovieDB.Controllers
{
    public class MoviesController : Controller
    {
        private IGenericRepository _repo;

        public MoviesController(IGenericRepository repo)
        {
            _repo = repo;
        }
        
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _repo.Query<Movie>().Include(m => m.Genre).ToList();
            return View(movies);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repo.Add<Movie>(movie);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.Find<Movie>(id));
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var originalMovie = _repo.Find<Movie>(movie.Id);
                originalMovie.Title = movie.Title;
                originalMovie.Director = movie.Director;
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
           return View(_repo.Find<Movie>(id));
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.Delete<Movie>(id);
            return RedirectToAction("Index");
        }
    }
}
