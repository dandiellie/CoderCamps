﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        //static void DoSomething(string value)
        //{
        //    value = "Goodbye!";
        //}

        static void Increment(ref int n)
        {
            n++;
        }

        static void Main(string[] args)
        {
            //var message1 = "Hello!";
            //DoSomething(message1);
            //Console.WriteLine("The value of message1 is " + message1);

            int num = 5;
            Increment(ref num);

            Debug.Assert(num == 6, "The incremented integer should be: " + 6);

            //Random myRand = new Random();
            //ArrayList headlines = new ArrayList();
            //headlines.Add("Martians Attack!!");
            //headlines.Add("Astros Win World Series!!");
            //headlines.Add("Coder Camps Amazes Students!!");
            //int length = 10; //sets the number of times the testing loop will run

            //int j = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    j = myRand.Next(3);
            //    Console.WriteLine(headlines[j]);
            //}

            //Console.ReadLine(); //pause
        }

    }
}
