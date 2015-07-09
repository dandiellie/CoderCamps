using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void DoSomething(string value)
        {
            value = "Goodbye!";
        }

        static void Increment(int n)
        {
            int m = n;
            n++;

            Debug.Assert(n == m+1, "The incremented integer should be: " + m);
        }

        static void Main(string[] args)
        {
            var message1 = "Hello!";
            DoSomething(message1);
            Console.WriteLine("The value of message1 is " + message1);

            Increment(5);

            // pause
            Console.ReadLine();
        }
    }
}
