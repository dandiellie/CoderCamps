using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    static class StringExtensions
    {
        public static void WriteColor(this string stringToExtend, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtend);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            "Everything is Awesome!".WriteColor(ConsoleColor.Yellow, ConsoleColor.Red);
            "When you go to Coder Camps!".WriteColor(ConsoleColor.DarkBlue, ConsoleColor.Green);

            // pause
            Console.ReadLine();
        }
    }
}
