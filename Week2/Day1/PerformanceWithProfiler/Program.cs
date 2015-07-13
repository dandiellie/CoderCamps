//This code is copied from our Coder Camps online textbook. The assignment is to
//reduce the amount of time it takes to run by half.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static List<Product> CreateProducts(int count)
        {
            var products = new List<Product>();
            var rnd = new Random();
            for (var i = 0; i < count; i++)
            {
                products.Add(new Product
                {
                    Id = rnd.Next(100),
                    Name = "Product " + i
                });
            }
            return products;
        }

        static void Main(string[] args)
        {
            // Create 1 thousand products with Random Ids
            List<Product> products = CreateProducts(1000);

            var q =    from x in products
                       group x by x into sortedProducts
                       let count = sortedProducts.Count()
                       orderby count descending
                       select new { Name = sortedProducts.Key.Name, Count = count };

            // Show unique list of products
            foreach (var x in q)
            {
                Console.WriteLine(x.Name + " is unique.");
            }

            // Pause
            Console.ReadLine();

        }
    }
}