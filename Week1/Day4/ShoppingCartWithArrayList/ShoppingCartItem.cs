using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithArrayList
{
    class ShoppingCartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ShoppingCartItem(string name, decimal price, int id = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
