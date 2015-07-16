using DisplayMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayMovies.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieIndexViewModel vm = new MovieIndexViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(MovieIndexViewModel vm)
        {
            return View(vm);
        }
    }
}