using CodeFirstPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstPractice.Controllers
{
    public class RestaurantsController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Restaurants
        public ActionResult Index()
        {
            var restaurants = from r in _db.Restaurants select r;
            return View(restaurants.ToList());
        }

        //// GET: Restaurants/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Restaurants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        [HttpPost]
        public ActionResult Create(Restaurant r)
        {
            if(ModelState.IsValid)
            {
                _db.Restaurants.Add(r);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Restaurants/Edit/5
        public ActionResult Edit(int id)
        {
            Restaurant r = _db.Restaurants.Find(id);
            return View(r);
        }

        // POST: Restaurants/Edit/5
        [HttpPost]
        public ActionResult Edit(Restaurant r)
        {
            if (ModelState.IsValid)
            {
                Restaurant original = _db.Restaurants.Find(r.Id);
                original.Name = r.Name;
                original.Description = r.Description;
                original.PriceRange = r.PriceRange;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Restaurants/Delete/5
        public ActionResult Delete(int id)
        {
            Restaurant r = _db.Restaurants.Find(id);
            return View(r);
        }

        // POST: Restaurants/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            Restaurant original = _db.Restaurants.Find(id);
            _db.Restaurants.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
