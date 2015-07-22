using ProductApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Presentation.Web.Models
{
    public class IndexViewModel
    {
        public IList<ProductDTO> Products { get; set; }
    }
}