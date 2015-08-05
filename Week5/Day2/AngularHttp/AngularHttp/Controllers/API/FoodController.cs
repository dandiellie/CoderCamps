using AngularHttp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularHttp.Controllers.API
{
    public class FoodController : ApiController
    {
        [Route("api/food/{search}")]
        public IHttpActionResult Get(string search)
        {
            var all = new List<Food>
            {
                new Food { Id=1, Name="Milk" },
                new Food { Id=2, Name="Marzipan" },
                new Food { Id=3, Name="Mustard" },
                new Food { Id=4, Name="Eggs" }
            };

            var filtered = all.Where(f => f.Name.StartsWith(search, StringComparison.InvariantCultureIgnoreCase));

            return Ok(filtered);
        }
    }
}
