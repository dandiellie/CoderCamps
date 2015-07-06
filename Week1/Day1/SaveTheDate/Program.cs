using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheDate
{
    class Program
    {
        static DateTime ToDate(string s)
        {
            char delimiter = '/';
            string[] pieces = s.Split(delimiter);

            int month = Convert.ToInt32(pieces[0]);
            int day = Convert.ToInt32(pieces[1]);
            int year = Convert.ToInt32(pieces[2]);

            DateTime thisDate = new DateTime(year, month, day);
            return thisDate;
        }
        
        static void Main(string[] args)
        {
            string userDate = "";
            
            Console.Write("Enter a date in MM/DD/YY format:");
            userDate = Console.ReadLine();

            DateTime formattedDate = ToDate(userDate);

            Console.WriteLine("The date you entered was: " + formattedDate.ToString("D"));
        }
    }
}
