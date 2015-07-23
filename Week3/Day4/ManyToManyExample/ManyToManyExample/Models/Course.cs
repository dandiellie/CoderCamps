using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyExample.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<StudentCourse> Students { get; set; }
    }
}