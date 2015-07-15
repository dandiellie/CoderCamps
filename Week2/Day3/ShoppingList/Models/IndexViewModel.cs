using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class IndexViewModel
    {
        public List<SelectViewModel> Customers { get; set; }
        public int SelectedId { get; set; }
    }
}