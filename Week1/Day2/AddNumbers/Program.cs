using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            Debug.Assert(myMath.AddInt(3, 2) == 5, "3+2=5");
            Debug.Assert(myMath.AddInt(0, 2) == 2, "0+2=2");
            Debug.Assert(myMath.AddInt(3, 3, 3) == 9, "3+3+3=9");
        }
    }

    class Math
    {
        public int AddInt(params int[] list)
        {
            int result = 0;

            foreach (int item in list)
            {
                result += item;
            }

            return result;
        }

        public decimal DoSomething(int a, int b)
        {
            return a / b;
        }

        public int DoSomething(int a, int b, int c)
        {
            return AddInt(a, b, c);
        }

        public decimal DoSomething(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }
    }
}
