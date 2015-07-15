using ShoppingList2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList2.Controllers
{
    public class ShoppingListController : Controller
    {
        private ShoppingListService _service = new ShoppingListService();
        
        // GET: ShoppingList
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel
            {
                FirstName = "Danielle",
                LastName = "Frederick",
                ShoppingCart = _service.GetItems()
            };

            vm.Total = vm.ShoppingCart.Sum(p => p.Price);
            
            return View(vm);
        }

        public ActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            return View();
        }
    }
}