using MVCwithJSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCwithJSON.Controllers.Api
{
    public class ProductsController : ApiController
    {
        public IHttpActionResult Get()
        {
            var products = new List<Product>
            {
                new Product { Name = "Milk", Price = 2.33m},
                new Product { Name = "Cheese", Price = 55.33m},
                new Product { Name = "Tesla", Price = 8989.33m}
            };

            return Ok(products);
        }
    }
}
