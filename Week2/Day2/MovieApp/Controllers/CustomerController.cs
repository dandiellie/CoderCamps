using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class CustomerController : Controller
    {
        public Customer ThisCustomer { get; set; }

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer c)
        {
            //try
            //{
            //    ThisCustomer = new Customer
            //    {
            //        FirstName = c.FirstName,
            //        LastName = c.LastName,
            //        ShippingAddress = c.ShippingAddress,
            //        BillingAddress = c.BillingAddress,
            //    };

            //    return RedirectToAction("ViewCustomerDetails");
            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Customer/ViewCustomerDetails
        public ActionResult ViewCustomerDetails()
        {
            return View();
        }
    }
}