using ASPNetIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Security.Claims;

namespace ASPNetIdentityDemo.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles=Role.ADMIN)]
        
        // GET: Admin
        public ActionResult Index()
        {
            if(User.IsInRole(Role.ADMIN))
            {
                //Do some stuff
            }

            //Get the currently logged in user's username
            string userName = User.Identity.Name;
            string userId = User.Identity.GetUserId(); //using Microsoft.AspNet.Identity;
            bool canEditProducts = (User.Identity as ClaimsIdentity).HasClaim("canEditProducts", "true");

            return Content("You're an Admin congrats!");
        }
    }
}