using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int? value = null;

            value = "89898".TryParseAsInt();
            Console.WriteLine(value);                       //will write "89898"

            value = "I am not a number".TryParseAsInt();
            Console.WriteLine(value);                       //will write a blank line

            value = "6.5".TryParseAsInt();
            Console.WriteLine(value);                       //will write a blank line

            Console.ReadLine(); //pause
        }
    }

    static class StringExtensions
    {
        public static int? TryParseAsInt(this string s)
        {
            int n = 0;

            //if (int.TryParse(s, out n))
            //    return n;
            //else
            //    return null;

            return int.TryParse(s, out n) ? n : default(int?);
        }
    }
}
