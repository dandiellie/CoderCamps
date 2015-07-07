using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };

            ContractEmployee emp2 = new ContractEmployee
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };

            Debug.Assert(emp1.ShowFullName() == "Bill Gates", "His name is Bill Gates.");
            Debug.Assert(emp1.YearsEmployed == 5, "He's worked here 5 years.");

            Debug.Assert(emp2.ShowFullName() == "Steve Jobs", "His name is Steve Jobs.");
            Debug.Assert(emp2.MonthsEmployed == 2, "He's worked here 2 months.");
        }
    }

    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ShowFullName()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }

    class FullTimeEmployee: Employee
    {
        public int YearsEmployed { get; set; }
    }

    class ContractEmployee: Employee
    {
        public int MonthsEmployed { get; set; }
    }
}
