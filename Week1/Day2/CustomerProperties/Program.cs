using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (_age < 0) { _age = 0; }
            }
        }

        public DateTime Birthdate { get; set; }

        public string Display()
        {
            return string.Format("Name: {0} {1}, Age: {2}, Birth Date: {3}", this.FirstName, this.LastName, this.Age, this.Birthdate);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer()
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                Birthdate = DateTime.Parse("2028-01-01")
            };

            Customer cust2 = new Customer()
            {
                FirstName = "Mike",
                LastName = "Harrison",
                //Age = 10,
                Age = -5,
                Birthdate = DateTime.Parse("2019-01-01")
            };

            Debug.Assert(cust1.Age == 23, "Sally is 23.");
            //Debug.Assert(cust2.Age == 10, "Mike is 10.");

            Debug.Assert(cust2.Age == 0, "Mike cannot be younger than 0.");

            //pause
            Console.ReadLine();
        }
    }
}
