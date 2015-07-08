using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; private set; }

        public Product(string name, decimal price, int unitsInStock)
        {
            Name = name;
            Price = price;
            UnitsInStock = unitsInStock;
        }

        public Product(string name, decimal price, int unitsInStock, string description)
        {
            Name = name;
            Price = price;
            UnitsInStock = unitsInStock;
            Description = description;
        }
    }
}
