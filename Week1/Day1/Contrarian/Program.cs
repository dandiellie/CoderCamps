using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrarian
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "";
            
            //welcome statement
            Console.WriteLine("I am the Contrarian. Tell me something you like or dislike.");

            do
            {
                Console.WriteLine("Enter a statement that begins 'I like...' or 'I don't like...'");
                statement = Console.ReadLine();
                int n = statement.Length;

                if (IsLike(statement))
                {
                    break;
                }
                else if (IsDislike(statement))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid format! Please try again!");
                }
            } while (true);
        }

        public bool IsLike(string s)
        {
            using (StringReader myReader = new StringReader(s))
            {
                //empty!!! This is a mess!!
            }

            return false;
        }

        public bool IsDislike(string s)
        {
            //empty method!!

            return false;
        }
    }
}
