using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Citizen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Citizen(string fn, string ln, DateTime bd)
        {
            FirstName = fn;
            LastName = ln;
            BirthDate = bd;
        }
    }
}
