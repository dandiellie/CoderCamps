using CalculatorForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorForm.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AddViewModel vm)
        {
            vm.Add();
            return View(vm);
        }


    }
}