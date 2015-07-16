using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreLayout.Controllers
{
    public class QuoteController : Controller
    {
        [ChildActionOnly]
        // GET: Quote
        public ActionResult GetQuote()
        {
            Random myRand = new Random();
            List<string> quotes = new List<string>
            {
                "Treat your password like your toothbrush. Don't let anybody else use it, and get a new one every six months. ~ Clifford Stoll",
                "Man is still the most extraordinary computer of all. ~ John F. Kennedy",
                "To err is human, but to really foul things up you need a computer. ~ Paul R. Ehrlich",
                "A computer once beat me at chess, but it was no match for me at kick boxing. ~ Emo Philips",
                "The good news about computers is that they do what you tell them to do. The bad news is that they do what you tell them to do. ~ Ted Nelson"
            };
            
            return PartialView("_Quote", quotes[myRand.Next(5)]);
        }
    }
}