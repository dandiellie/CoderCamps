using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 19.99m;
            decimal taxRate = 0.08m;

            Console.WriteLine(string.Format("Your total is: {0:c}.", CalculateTotalPriceWithTax(price, taxRate)));
            Console.ReadLine();
        }

        static decimal CalculateTotalPriceWithTax(decimal price, decimal taxRate)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("price", "Product price cannot be less than 0.");
            }
            if (taxRate < 0 || taxRate > 0.1m)
            {
                throw new ArgumentOutOfRangeException("taxRate", "Product tax rate cannot be less than 0 or greater than 10%.");
            }
            
            return price + (price * taxRate);
        }
    }
}
