using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingData.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Milk", Price = 2.33m},
                new Product {Name = "Eggs", Price = 1.09m},
                new Product {Name = "Cheese", Price = 12.00m}
            };

            IndexViewModel model = new IndexViewModel
            {
                Products = products
            };
            
            return View(model);
        }
    }
}