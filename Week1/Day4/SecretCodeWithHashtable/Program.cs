using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCodeWithHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();
            Enigma myCode = new Enigma(myRand);
            int userChoice;
            string userMessage;

            do
            {
                Console.Write("Enter '1' to Encrypt a message, '2' to Decrypt a message, or '0' to Exit: ");
                userChoice = Int32.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("\nWhat message would you like to encrypt?\n");
                        userMessage = Console.ReadLine().ToUpper();
                        Console.WriteLine(myCode.Encrypt(userMessage));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("\nWhat message would you like to decrypt?\n");
                        userMessage = Console.ReadLine().ToUpper();
                        Console.WriteLine(myCode.Decrypt(userMessage));
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (userChoice != 0);
        }
    }
}
