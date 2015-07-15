using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList2.Models
{
    public class ShoppingListService
    {
        public IList<Product> GetItems()
        {
            return new List<Product>
            {
                new Product {Name="Kicks", Price=89.99m},
                new Product {Name="Mouse", Price=25.87m},
                new Product {Name="Mountain Dew Game Fuel", Price=7.58m}
            };
        }
    }
}