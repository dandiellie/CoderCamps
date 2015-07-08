using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            int length = 10; //sets the length of the loop for testing
            string[] headlines = new string[3] {"Martians Attack!", "Astros Win World Series!", "Coder Camps Best Course Ever!"};

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(headlines.GetRandom(myRand));
            }

            //pause
            Console.ReadLine();
        }
    }

    static class ArrayExtensions
    {
        public static string GetRandom(this string[] s, Random r)
        {
            return s[r.Next(3)];
        }
    }
}
