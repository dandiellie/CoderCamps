using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithArrayList
{
    class ShoppingCart
    {
        public ArrayList cart { get; set; }
        public int newItemNum { get; private set; }

        public ShoppingCart()
        {
            cart = new ArrayList();
            newItemNum = 1;
        }

        public int AddItem(string name, decimal price)
        {
            ShoppingCartItem item = new ShoppingCartItem(name, price, newItemNum++);
            cart.Add(item);
            return item.Id;
        }

        public void RemoveItem(int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (((ShoppingCartItem)cart[i]).Id == id)
                {                    
                    cart.RemoveAt(i);
                    break;
                }
            }
            

        }

        public void ListItems()
        {            
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine(string.Format("Item #{0} is {1} and costs {2:c}.", ((ShoppingCartItem)cart[i]).Id, ((ShoppingCartItem)cart[i]).Name, ((ShoppingCartItem)cart[i]).Price));
            }
        }
    }
}
