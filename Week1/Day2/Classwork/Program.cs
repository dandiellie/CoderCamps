using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    //Part 2
    class Product
    {
        public string Name { get; set; }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The price can't be less than zero.");
                }

                _price = value;
            }
        }

        public decimal CalculateTax(decimal taxRate = .08m)
        {
            return this.Price * taxRate;
        }
        public decimal CalculateTax(decimal taxRate, decimal discount)
        {
            return (this.Price - (this.Price * discount)) * taxRate;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            //string productName = "laptop";
            //decimal price = 344.55m;
            //string message = String.Format("The {0} costs {1:c}.", productName, price);

            //Console.WriteLine(message);
            //Console.ReadLine();


            //Part 2
            Product product1 = new Product()
            {
                Name = "Milk",
                Price = 2.33m
            };

            Product product2 = new Product()
            {
                Name = "Eggs",
                Price = 1.33m
            };

            Console.WriteLine(string.Format("{0}: {1:c} + {2:c} tax", product1.Name, product1.Price, product1.CalculateTax()));
            Console.WriteLine(string.Format("{0}: {1:c} + {2:c} tax", product2.Name, product2.Price, product2.CalculateTax(.08m,.2m)));

            //pause
            Console.ReadLine();
        }
    }
}
