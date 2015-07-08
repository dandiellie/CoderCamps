using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {         
            Customer alice = new Customer
            {
                FirstName = "Alice",
                MiddleInitial = "N",
                LastName = "Wonderland",
                BillingAddress = new Address
                {
                    Street = "210 Jackson Street",
                    City = "Houston",
                    ZIP = "70512"
                },
                CheckingAccount = new Account
                {
                    IdNum = 789321456,
                    Type = AccountType.Checking,
                    Balance = 100m,
                    IsOpen = true
                },
                SavingsAccount = new Account
                {
                    IdNum = 789321654,
                    Type = AccountType.Savings,
                    Balance = 0m,
                    IsOpen = false
                }
            };

            Console.WriteLine(string.Format("{0} {1} {2}", alice.FirstName, alice.MiddleInitial, alice.LastName));

            Customer.Transfer(alice.CheckingAccount, alice.SavingsAccount, 23.45m);
            Console.WriteLine(string.Format("{0} has {1} in checking and {2} in savings.", alice.FirstName, alice.CheckingAccount.Balance, alice.SavingsAccount.Balance));

            //pause
            Console.ReadLine();
        }
    }

    enum AccountType
    {
        Checking, Savings
    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
    }

    class Account
    {
        public int IdNum { get; set; }
        public AccountType Type;
        public decimal Balance { get; set; }
        public bool IsOpen { get; set; }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingsAccount { get; set; }

        public static void Transfer(Account transFrom, Account transTo, decimal transAmount)
        {
            transFrom.Balance -= transAmount;
            transTo.Balance += transAmount;
        }
    }
}
