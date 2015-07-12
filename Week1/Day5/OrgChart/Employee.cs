using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee DirectBoss { get; set; }
        public List<Employee> Minions { get; set; }

        public Employee(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Minions = new List<Employee>();
        }

        public void PrintEmployeeInfo()
        {
            try
            {
                Console.WriteLine(string.Format("\n{0} {1} reports to {2} {3} and has the following employee(s) under him/her:", FirstName, LastName, DirectBoss.FirstName, DirectBoss.LastName));
            }
            catch
            {
                Console.WriteLine(string.Format("\n{0} {1} reports to (none) and has the following employee(s) under him/her:", FirstName, LastName));
            }
            
            foreach (Employee minion in Minions)
            {
                Console.Write(string.Format("{0} {1} ", minion.FirstName, minion.LastName));
            }
            Console.WriteLine();
        }
    }
}