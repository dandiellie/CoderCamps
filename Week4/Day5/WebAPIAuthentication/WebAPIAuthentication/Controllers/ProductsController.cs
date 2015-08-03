using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPIAuthentication.Models;

namespace WebAPIAuthentication.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name="Black Chucks", Price=49.99m},
                new Product { Id = 2, Name="Red Chucks", Price=49.99m},
                new Product { Id = 3, Name="Yellow Chucks", Price=49.99m},
                new Product { Id = 4, Name="Purple Chucks", Price=49.99m},
                new Product { Id = 5, Name="Blue Chucks", Price=49.99m},
                new Product { Id = 6, Name="Green Chucks", Price=49.99m},
                new Product { Id = 7, Name="White Chucks", Price=49.99m},
                new Product { Id = 8, Name="Orange Chucks", Price=49.99m}
            };
            return View(products);
        }

        public ActionResult SaveOrder(int[] order)
        {
            //save order to db
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Find(string term)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name="Black Chucks", Price=49.99m},
                new Product { Id = 2, Name="Red Chucks", Price=49.99m},
                new Product { Id = 3, Name="Yellow Chucks", Price=49.99m},
                new Product { Id = 4, Name="Purple Chucks", Price=49.99m},
                new Product { Id = 5, Name="Blue Chucks", Price=49.99m},
                new Product { Id = 6, Name="Green Chucks", Price=49.99m},
                new Product { Id = 7, Name="White Chucks", Price=49.99m},
                new Product { Id = 8, Name="Orange Chucks", Price=49.99m}
            };

            var matches = products
                .Where(p => p.Name.StartsWith(term, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

            return Json(matches, JsonRequestBehavior.AllowGet);
        }
    }
}