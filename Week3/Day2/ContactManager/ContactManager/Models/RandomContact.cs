using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public static class RandomContact
    {
        public static Contact GetRandomContact(this Random r)
        {
            return new Contact
            {
                FirstName = GetRandomFirstName(r),
                LastName = GetRandomLastName(r),
                Birthday = GetRandomBirthday(r),
                PhoneNumber = GetRandomPhoneNumber(r)
            };
        }

        private static string GetRandomFirstName(Random r)
        {
            string[] firstNames= {"Ana", "Bill", "Claude", "Dani", "Erik", "Fred", "Grace", "Henri", "Isabella", "Joseph"};
            return firstNames[r.Next(10)];
        }

        private static string GetRandomLastName(Random r)
        {
            string[] lastNames = { "Mouton", "Aubert", "LaHaye", "Broussard", "Stoute", "Muller", "Gandy", "Breaux", "Hebert", "Chiasson" };
            return lastNames[r.Next(10)];
        }

        private static DateTime GetRandomBirthday(Random r)
        {
            int year = (r.Next(85) + 1930);
            int month = (r.Next(12) + 1);
            int day = (r.Next(28) + 1);

            return new DateTime(year, month, day);
        }

        private static string GetRandomPhoneNumber(Random r)
        {
            string phoneNumber = "";

            phoneNumber += (r.Next(9) + 1).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += (r.Next(9) + 1).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();
            phoneNumber += r.Next(10).ToString();

            return phoneNumber;
        }
    }
}