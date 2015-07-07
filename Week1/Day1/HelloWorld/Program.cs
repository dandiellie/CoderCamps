using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace W1D1P1HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("HelloWorld.txt"))
            {
                Console.WriteLine("It Exists!");
            }
            else
            {
                Console.WriteLine("Nope, not here!");
            }

            Console.ReadLine();
        }
    }
}
