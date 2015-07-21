using ASPNetMovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ASPNetMovieDB.Controllers
{
    public class MoviesController : Controller
    {
        private IRepository _repo;

        public MoviesController() : this (new EFRepository())
        {

        }

        public MoviesController(IRepository repo)
        {
            _repo = repo;
        }
        
        // GET: Movies
        public ActionResult Index()
        {
            return View(_repo.ListMovies());
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
                _repo.CreateMovie(movie);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.FindMovie(id));
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateMovie(movie);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
           return View(_repo.FindMovie(id));
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.DeleteMovie(id);
            return RedirectToAction("Index");
        }
    }
}
