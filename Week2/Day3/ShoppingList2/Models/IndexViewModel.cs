using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList2.Models
{
    public class IndexViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Product> ShoppingCart { get; set; }
        public decimal Total { get; set; }
    }
}