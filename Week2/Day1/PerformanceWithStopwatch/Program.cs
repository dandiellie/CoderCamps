//This code is copied from our Coder Camps online textbook. The assignment is to
//reduce the amount of time it takes to run by half.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of 1000 random numbers
            var numberList = new List<int>();
            var rnd = new Random();
            for (var i = 0; i < 1000; i++)
            {
                numberList.Add(rnd.Next(1000));
            }

            // Start Stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Display count of duplicates
            foreach (var number1 in numberList)
            {
                var duplicateCount = 0;
                foreach (var number2 in numberList)
                {
                    if (number1 == number2)
                    {
                        duplicateCount++;
                    }
                }
                Console.WriteLine("{0} has {1} duplicates.", number1, duplicateCount);
            }

            // Stop Stopwatch
            stopwatch.Stop();
            Console.WriteLine("Total time is {0} milliseconds.", stopwatch.ElapsedMilliseconds);

            // Pause
            Console.ReadLine();
        }
    }
}
