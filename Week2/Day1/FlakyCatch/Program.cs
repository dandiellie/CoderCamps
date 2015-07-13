using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlakyCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            
            try
            {
                Flaky(myRand);
                Console.WriteLine("Flaky was called successfully.");
            }
            catch
            {
                Console.WriteLine("Yikes! There was an error.");
            }
            finally
            {
                Console.WriteLine("Finished calling Flaky.");
            }

            Console.ReadLine();  //pause
        }

        static void Flaky(Random r)
        {
            int choice = r.Next(2);
            if(choice==0)
            {
                throw new Exception("Haha! You lose!");
            }
        }
    }
}
