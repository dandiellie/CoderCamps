using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWordsWithHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text, and I will tell you how many unique words you entered.");
            int num = CountUnique(Console.ReadLine());

            Console.WriteLine("\nYou entered " + num + " unique words.");

            Console.ReadLine(); //pause
        }

        static int CountUnique(string s)
        {
            char[] delimiter = { ' ', '!', '"', '#', '$', '%', '&', '(', ')', '.', '*', '+', ',', '/', '?', ':', ';', '@', '`' };
            string[] words = s.Split(delimiter);

            Hashtable uniqueWordList = new Hashtable();
            string word = "";

            for (int i = 0; i < words.Length; i++)
            {
                word = words[i].ToLower();
                if(uniqueWordList.ContainsKey(word) || word == "")
                {
                    continue;
                }
                else
                {
                    uniqueWordList.Add(word, word);
                    //Console.Write(word + " ");            //included for testing
                }                
            }

            return uniqueWordList.Count;
        }
    }
}
