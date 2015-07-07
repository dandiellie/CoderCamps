using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNewsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            int selection = myRand.Next(3);
            string[] headlines = {"Martians Attack!", "Astros win World Series!", "Perry the Platypus has been found!"};

            Console.WriteLine("TODAY'S HEADLINE\n");
            Console.WriteLine(headlines[selection]);
            Console.ReadLine();
        }
    }
}
