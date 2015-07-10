using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Task<int> result = Task<int>.Factory.StartNew(() => 1);

            Console.Write("Enter the 1st number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            num2 = int.Parse(Console.ReadLine());
            result = SlowAdd(num1, num2);
            Console.WriteLine(string.Format("\nThe sum of {0} and {1} is {2}.", num1, num2, result.Result));

            Console.ReadLine();
        }

        public async static Task<int> SlowAdd(int a, int b)
        {
            await Task.Delay(5000);
            return a + b;
        }
    }
}
