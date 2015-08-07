using AngularServices.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularServices.Controllers.API
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products;

        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product>
            {
                new Product { Id=1, Name="Peanut Butter", Price=3.99m },
                new Product { Id=2, Name="Jelly", Price=4.99m }
            });
        }

        public IHttpActionResult Get()
        {
            
            return Ok(_products);
        }

        public IHttpActionResult Post(Product product)
        {
            _products.Push(product);
            return Ok();
        }
    }
}
