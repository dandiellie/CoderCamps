using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "laptop";
            decimal price = 344.55m;
            string message = String.Format("The {0} costs {1:c}.", productName, price);

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
