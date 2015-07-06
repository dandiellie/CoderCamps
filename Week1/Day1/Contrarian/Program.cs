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
            string output = "";
            bool play = false;
            
            //welcome statement
            Console.WriteLine("I am the Contrarian. Tell me something you like or dislike.");

            do
            {
                do
                {
                    //accept a statement
                    Console.WriteLine("Enter a statement that begins 'I like...' or 'I don't like...'\n");
                    statement = Console.ReadLine();

                    //The following lines were included for debugging.
                    //Console.WriteLine(RemoveWords(statement, 4));
                    //break;

                    if (IsLike(statement))
                    {
                        //if the user likes something do this
                        output = "I don't like " + RemoveWords(statement, 2);
                        break;
                    }
                    else if (IsDislike(statement))
                    {
                        //if the user dislikes something do this
                        output = "I like " + RemoveWords(statement, 3);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid format! Please try again!");
                    }
                } while (true);

                Console.WriteLine("\n" + output);

                Console.WriteLine("Would you like to exit? Enter '1' to CONTINUE or '0' to EXIT.");
                play = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            } while (play);

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

        //checks if a statement expresses like and is in the right format
        static bool IsLike(string s)
        {
            char delimiter = ' ';
            string[] words = s.Split(delimiter);
            int l = words.GetLength(0);

            if (words[0]=="I" && words[1]=="like")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //checks if a statement expresses dislike and is in the right format
        static bool IsDislike(string s)
        {
            char delimiter = ' ';
            string[] words = s.Split(delimiter);
            int l = words.GetLength(0);

            if (words[0]=="I" && words[1]=="don't" && words[2]=="like")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //removes n words from the beginning of a string
        static string RemoveWords(string s, int n)
        {
            char delimiter = ' ';
            string[] words = s.Split(delimiter);
            int l = words.GetLength(0);

            //clear string s
            s = "";

            for (int i = n; i < l; i++)
            {
                s = s + words[i] + " ";
            }

            return s;
        }
    }
}
