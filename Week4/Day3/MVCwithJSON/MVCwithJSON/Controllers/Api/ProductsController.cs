using MVCwithJSON.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCwithJSON.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products;

        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product>
            {
                new Product { Name = "Milk", Price = 2.33m},
                new Product { Name = "Cheese", Price = 55.33m},
                new Product { Name = "Tesla", Price = 8989.33m}
            });
        }
        
        public IHttpActionResult Get()
        {
            var products = _products;
            
            return Ok(products);
        }

        public HttpResponseMessage Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _products.Push(product);
                return Request.CreateResponse(HttpStatusCode.Created, product);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }
    }
}
