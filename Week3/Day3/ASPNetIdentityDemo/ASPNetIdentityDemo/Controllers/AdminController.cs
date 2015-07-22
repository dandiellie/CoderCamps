using ASPNetIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetIdentityDemo.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles=Role.ADMIN)]
        
        // GET: Admin
        public ActionResult Index()
        {
            return Content("You're an Admin congrats!");
        }
    }
}