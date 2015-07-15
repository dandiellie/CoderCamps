using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingListService
    {
        private static Customer will = new Customer
        {
            Id = 1,
            FirstName = "William",
            LastName = "Hebert",
            Cart = new List<Product>
            {
                new Product {Name = "Basketball", Price = 15.55m},
                new Product {Name = "Rubik's Cube", Price = 12.49m},
                new Product {Name = "Headphones", Price = 5.89m}
            },
            CartTotal = (15.55m+12.49m+5.89m)
        };

        private static Customer luke = new Customer
        {
            Id = 2,
            FirstName = "Lucas",
            LastName = "Menard",
            Cart = new List<Product>
            {
                new Product {Name = "Hair Gel", Price = 6.47m},
                new Product {Name = "Flaming Hot Cheetos", Price = 3.24m},
                new Product {Name = "Headphones", Price = 5.89m}
            },
            CartTotal = (6.47m+3.24m+5.89m)
        };

        public static List<SelectViewModel> GetCustomerSelectViewModel()
        {
            return new List<SelectViewModel>
                {new SelectViewModel {Id = 1, Value = "Hebert"},
                new SelectViewModel {Id = 2, Value = "Menard"}};
        }

        public static Customer GetItems(string name)
        {
            if (name == will.LastName) return will;
            else return luke;
        }
    }
}