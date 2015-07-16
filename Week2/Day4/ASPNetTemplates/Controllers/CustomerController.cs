using ASPNetTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetTemplates.Controllers
{
    public class CustomerController : Controller
    {
        private IList<Customer> _customers;

        public CustomerController()
        {
            _customers = new List<Customer>
            {
                new Customer {Id=1, FirstName="Danielle", LastName="Frederick", PhoneNumber=8328160167},
                new Customer {Id=2, FirstName="Carmen", LastName="Louviere", PhoneNumber=2812165060}
            };
        }
        
        // GET: Customer
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
            Customer cust = _customers.FirstOrDefault(p => p.Id == id);
            return View(cust);
        }
    }
}