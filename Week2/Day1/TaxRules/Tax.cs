using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Tax
    {
        public DateTime Today { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxDiscount { get; set; }

        public Tax()
        {
            TaxRate = 0.08m;
            TaxDiscount = 0m;
        }

        public decimal Calculate(Citizen person, decimal price)
        {
            IsLessThanFive(person.BirthDate);
            IsLastNameW(person.LastName);
            IsFirstNameJ(person.FirstName);
            IsThursday();
            IsTaxNonNegative(price);

            return price + (price * TaxRate) - TaxDiscount;
        }

        public void IsLessThanFive(DateTime birthdate)
        {
            Today = DateTime.Now;
            int age = Today.Year - birthdate.Year;
            if (birthdate > Today.AddYears(-age)) age--;
            if (age < 5) { TaxRate = 0; }
        }

        public void IsLastNameW(string lastName)
        {
            if (string.Compare(lastName.ToUpper(), 0, "W", 0, 1) == 0) { TaxDiscount = 1m; }
        }

        public void IsFirstNameJ(string firstname)
        {
            if (string.Compare(firstname.ToUpper(), 0, "J", 0, 1) == 0) { TaxRate = TaxRate * 2; }
        }

        public void IsThursday()
        {
            Today = DateTime.Now;
            if (Today.DayOfWeek == DayOfWeek.Thursday) { TaxRate = TaxRate * 2; }
        }

        public void IsTaxNonNegative(decimal price)
        {
            if ((price*TaxRate-TaxDiscount) < 0) { TaxDiscount = 0m; }
        }
    }
}
