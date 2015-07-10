using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounter myCounter = new WordCounter();
            int timesUsed = 0;

            Tuple<List<string>, int> mostUsedWord = myCounter.MostUsedWordIn(File.ReadAllText("Hamlet.txt"));
            timesUsed = mostUsedWord.Item2;
            Console.WriteLine(string.Format("The most used word(s) was used {0} times. The word(s) was\n", timesUsed));

            foreach(string s in mostUsedWord.Item1)
            {
                Console.Write(string.Format("{0} ", s));
            }

            Console.ReadLine();
        }
    }
}
