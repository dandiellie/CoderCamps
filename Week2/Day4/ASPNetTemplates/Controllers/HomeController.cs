using ASPNetTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetTemplates.Controllers
{
    public class HomeController : Controller
    {
        private IList<Product> _products;

        public HomeController()
        {
            _products = new List<Product>
            {
                new Product {Id=1, Name="White Citrus Hand Lotion", Price=12.50m, Weight=7.5m},
                new Product {Id=2, Name="Ocean Fresh Hand Lotion", Price=12.50m, Weight=7.5m}
            };
        }
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Product prod = _products.FirstOrDefault(p => p.Id == id);
            return View(prod);
        }
    }
}