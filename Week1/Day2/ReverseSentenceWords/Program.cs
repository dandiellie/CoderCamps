using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentenceWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Enter a sentence.");
            sentence = Console.ReadLine();

            char delimiter = ' ';
            string[] words = sentence.Split(delimiter);

            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
