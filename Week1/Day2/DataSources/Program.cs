using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataSources
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            
            ////create random strings for testing Counter
            RandomStringDataSource myString1 = new RandomStringDataSource(myRand, 10);
            RandomStringDataSource myString2 = new RandomStringDataSource(myRand, 100);
            RandomStringDataSource myString3 = new RandomStringDataSource(myRand, 1000);

            Console.WriteLine(myString1.str);
            Console.WriteLine(myString1.CountWords());
            Console.WriteLine();

            Console.WriteLine(myString2.str);
            Console.WriteLine(myString2.CountWords());
            Console.WriteLine();

            Console.WriteLine(myString3.str);
            Console.WriteLine(myString3.CountWords());
            Console.WriteLine();

 
            ////read .txt files for testing Counter
            //////make sure the files exist
            ////if (File.Exists("Whales.txt"))
            ////{
            ////    Console.WriteLine("It Exists!");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Nope, not here!");
            ////}

            FileDataSource myFile1 = new FileDataSource("Whales.txt");
            FileDataSource myFile2 = new FileDataSource("Color.txt");

            Console.WriteLine(myFile1.str);
            Console.WriteLine(myFile1.CountWords());
            Console.WriteLine();

            Console.WriteLine(myFile2.str);
            Console.WriteLine(myFile2.CountWords());
            Console.WriteLine();


            //read webpages for testing Counter
            InternetDataSource myWebpage1 = new InternetDataSource("https://en.wikipedia.org/wiki/Whale");
            InternetDataSource myWebpage2 = new InternetDataSource("https://en.wikipedia.org/wiki/Color");

            Console.WriteLine(myWebpage1.str);
            Console.WriteLine(myWebpage1.CountWords());
            Console.WriteLine();

            Console.WriteLine(myWebpage2.str);
            Console.WriteLine(myWebpage2.CountWords());
            Console.WriteLine();


            Console.ReadLine(); //pause
        }
    }

    abstract class Counter
    {
        public string str { get; set; }
        
        public int CountWords()
        {
            char[] delimiter = {' ', '!', '"', '#', '$', '%', '&', '(', ')', '.', '*', '+', ',', '/', '?', ':', ';', '@', '`'};
            string[] words = str.Split(delimiter);

            return words.Length;
        }
    }

    class RandomStringDataSource: Counter
    {
        public RandomStringDataSource(Random r, int size)
        {
            StringBuilder b = new StringBuilder();
            char ch = ' ';

            int randNum = 0;
            for (int i = 0; i < size; i++)
            {
                randNum = r.Next(62);
                if(randNum < 26)
                {
                    ch = Convert.ToChar(r.Next(26) + 65);
                    b.Append(ch);
                }
                else if (randNum < 52)
                {
                    ch = Convert.ToChar(r.Next(26) + 97);
                    b.Append(ch);
                }
                else if (randNum < 61)
                {
                    ch = Convert.ToChar(32);
                    b.Append(ch);
                }
                else
                {
                    ch = Convert.ToChar(46);
                    b.Append(ch);
                }
            }

            str = b.ToString();
        }
    }

    class FileDataSource : Counter
    {
        public FileDataSource(string filePath)
        {
            str = File.ReadAllText(filePath);
        }
    }

    class InternetDataSource: Counter
    {
        public InternetDataSource(string webAddress)
        {
            WebClient client = new WebClient();
            str = client.DownloadString(webAddress);
        }
    }
}
