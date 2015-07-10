using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfanityCleaner myCleaner = new ProfanityCleaner();

            Console.WriteLine("What message would you like to clean?");
            Console.WriteLine();                                                //blankline
            Console.WriteLine(myCleaner.Clean(Console.ReadLine()));
            Console.ReadLine();                                                 //pause
        }
    }
}
