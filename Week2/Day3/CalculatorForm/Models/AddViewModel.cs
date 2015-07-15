using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorForm.Models
{
    public class AddViewModel
    {
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }
        public decimal Total { get; set; }

        public void Add()
        {
            Total = Num1 + Num2;
        }
    }
}