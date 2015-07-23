using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyExample.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [InverseProperty("Courses")]
        public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [InverseProperty("Students")]
        public virtual Course Course { get; set; }

        public int Grade { get; set; }
    }
}