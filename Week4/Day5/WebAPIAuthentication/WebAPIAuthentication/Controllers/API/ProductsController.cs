using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIAuthentication.Models;

namespace WebAPIAuthentication.Controllers.API
{
    public class ProductsController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            var products = new List<Product>
            {
                new Product {Name = "Milk", Price = 2.33m},
                new Product {Name = "Cheese", Price = 8.33m}
            };

            return Ok(products);
            
            //var products = new List<dynamic>();
            //dynamic prod1 = new ExpandoObject();
            //prod1.Name = "Milk";
            //prod1.Price = 2.33m;

            //dynamic prod2 = new ExpandoObject();
            //prod2.Name = "Cheese";
            //prod2.Price = 8.33m;

            //products.Add(prod1);
            //products.Add(prod2);
            
            //return Ok(products);
        }
    }
}
