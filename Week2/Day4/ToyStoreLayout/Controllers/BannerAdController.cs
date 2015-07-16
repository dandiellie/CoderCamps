using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreLayout.Controllers
{
    public class BannerAdController : Controller
    {
        [ChildActionOnly]
        // GET: BannerAd
        public ActionResult GetAd()
        {
            string adText = "Drink a Vanilla Latte!";
            if(DateTime.Now.Hour > 12)
            {
                adText = "Drink a cup of Assam Tea!";
            }
            
            return PartialView("_BannerAd", adText);
        }
    }
}