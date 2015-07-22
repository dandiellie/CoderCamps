using ProductApp.Presentation.Web.Models;
using ProductApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp.Presentation.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
        
        // GET: Products
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Products = _service.List();

            return View(vm);
        }
    }
}