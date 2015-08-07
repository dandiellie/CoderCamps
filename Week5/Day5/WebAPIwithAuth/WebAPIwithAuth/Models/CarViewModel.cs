using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIwithAuth.Models
{
    public class CarViewModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public bool IsBadAss { get; set; }
        public string UserName { get; set; }
    }
}