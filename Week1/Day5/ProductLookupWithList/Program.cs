using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog searsCatalog = new ProductCatalog();
            int userIdNum;
            Console.Write("Enter the Product ID# for the item you would like to purchase: ");
            userIdNum = Convert.ToInt32(Console.ReadLine());
            Product userProduct = searsCatalog.Lookup(userIdNum);

            Console.WriteLine(string.Format("\nYou have chose to purchase a {0} for {1:c}.", userProduct.Name, userProduct.Price));
            Console.ReadLine(); //pause
        }
    }
}
