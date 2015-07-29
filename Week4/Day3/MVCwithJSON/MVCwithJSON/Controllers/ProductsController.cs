using MVCwithJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithJSON.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProduct()
        {
            var products = new List<Product>
            {
                new Product { Name = "Milk", Price = 2.33m},
                new Product { Name = "Cheese", Price = 55.33m},
                new Product { Name = "Tesla", Price = 8989.33m}
            };

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}