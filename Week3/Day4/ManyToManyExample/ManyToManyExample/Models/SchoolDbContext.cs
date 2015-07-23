using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManyToManyExample.Models
{
    public class SchoolDbContext : DbContext
    {
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Course> Courses { get; set; }
    }
}