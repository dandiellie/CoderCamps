using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class ProductCatalog
    {
         public Dictionary<int, Product> catalog { get; set; }

        public ProductCatalog()
        {
            catalog = new Dictionary<int, Product>();
            catalog.Add(123456, new Product { Id = 123456, Name = "Washing Machine", Price = 560.99m });
            catalog.Add(123457, new Product { Id = 123457, Name = "Dryer", Price = 460.99m });
            catalog.Add(456789, new Product { Id = 456789, Name = "Mini Fridge", Price = 99.99m });
        }

        public Product Lookup(int idNum)
        {
            do
            {
                if(catalog.ContainsKey(idNum))
                {
                    return catalog[idNum];
                }
                Console.Write("\nYou did not enter a valid Product ID. Please try again. ");
                idNum = Convert.ToInt32(Console.ReadLine());
            } while (true);
        }
    }
}
