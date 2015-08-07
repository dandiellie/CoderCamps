using System.Web.Http;
using WebAPIwithAuth.Data;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using WebAPIwithAuth.Models;
using System.Linq;

namespace WebAPIwithAuth.Controllers.API
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        [Authorize]
        public IHttpActionResult Get()
        {
            var userId = User.Identity.GetUserId();

            IList<CarViewModel> cars = _db.Cars
                .Where(c => c.UserId == userId)
                .Select(c => new CarViewModel
                {
                    Color = c.Color,
                    IsBadAss = c.IsBadAss,
                    Make = c.Make,
                    Model = c.Model,
                    Price = c.Price,
                    UserName = c.User.UserName
                }).ToList();

            return Ok(cars);
        }
    }
}
