using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList
{
    class ProductCatalog
    {
        public List<Product> catalog { get; set; }

        public ProductCatalog()
        {
            catalog = new List<Product>();
            catalog.Add(new Product { Id = 123456, Name = "Washing Machine", Price = 560.99m });
            catalog.Add(new Product { Id = 123457, Name = "Dryer", Price = 460.99m });
            catalog.Add(new Product { Id = 456789, Name = "Mini Fridge", Price = 99.99m });
        }

        public Product Lookup(int idNum)
        {
            do
            {
                foreach (Product p in catalog)
                {
                    if (p.Id == idNum)
                    {
                        return p;
                    }
                }
                Console.Write("\nYou did not enter a valid Product ID. Please try again. ");
                idNum = Convert.ToInt32(Console.ReadLine());
            } while (true);
        }
    }
}
