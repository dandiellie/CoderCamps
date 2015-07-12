using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bill = new Employee("Bill", "Mason");
            Employee sam = new Employee("Sam", "Garner");
            Employee fred = new Employee("Fred", "Gallagher");
            Employee jane = new Employee("Jane", "Faucet");
            Employee alice = new Employee("Alice", "Moreau");

            bill.Minions.Add(sam);
            bill.Minions.Add(fred);
            bill.Minions.Add(jane);
            sam.DirectBoss = bill;
            fred.DirectBoss = bill;
            jane.DirectBoss = bill;

            fred.Minions.Add(alice);
            alice.DirectBoss = fred;

            bill.PrintEmployeeInfo();
            sam.PrintEmployeeInfo();
            fred.PrintEmployeeInfo();
            jane.PrintEmployeeInfo();
            alice.PrintEmployeeInfo();

            Console.ReadLine();             //pause
        }
    }
}
