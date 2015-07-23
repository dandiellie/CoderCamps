using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyExample.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<StudentCourse> Courses { get; set; }
    }
}