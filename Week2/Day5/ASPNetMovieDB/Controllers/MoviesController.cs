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
        private DataContext _db = new DataContext();
        
        // GET: Movies
        public ActionResult Index()
        {
            var movies = from m in _db.Movies select m;
            return View(movies.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _db.Movies.Find(id);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _db.Movies.Find(id);
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var original = _db.Movies.Find(id);
            _db.Movies.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
