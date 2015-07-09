using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart WalmartCart = new ShoppingCart();
            WalmartCart.AddItem("Milk", 2.30m);
            WalmartCart.AddItem("Eggs", 0.99m);
            WalmartCart.AddItem("Bread", 3.89m);
            WalmartCart.AddItem("Lettuce", 0.70m);

            WalmartCart.ListItems();
            Console.WriteLine();

            Console.WriteLine("Enter the ID# of the item you'd like to remove.");
            WalmartCart.RemoveItem(int.Parse(Console.ReadLine()));
            WalmartCart.AddItem("Wine", 25.99m);
            Console.WriteLine();

            WalmartCart.ListItems();

            Console.ReadLine(); //pause
        }
    }
}
