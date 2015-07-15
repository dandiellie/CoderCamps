using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel
            {
                Customers = ShoppingListService.GetCustomerSelectViewModel()
            };
            return View(vm);
        }

        [HttpPost]
        // GET: ShoppingList
        public ActionResult Index(IndexViewModel vm)
        {
            return RedirectToAction("ShowCart", new {id = vm.SelectedId});
        }

        public ActionResult ShowCart(int id)
        {
            return Content("The id that was selected was" + id.ToString());
        }
    }
}