namespace ManyToManyExample.Migrations
{
    using ManyToManyExample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyExample.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyExample.Models.SchoolDbContext context)
        {
            //Seed Students
            var students = new Student[]
            {
                new Student {LastName="LaHaye", FirstName="Claudius"},
                new Student {LastName="Stoute", FirstName="Alton"},
                new Student {LastName="Mouton", FirstName="Seth"}
            };

            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);

            //Seed Courses
            var courses = new Course[]
            {
                new Course {Code="MATH217", Name="Calculus II"},
                new Course {Code="COSC100", Name="Intro to C#"},
                new Course {Code="PHYS100", Name="Intro to Physics"}
            };

            context.Courses.AddOrUpdate(c => c.Code, courses);
            context.SaveChanges();

            //Add Students to Courses
            var claudius = context.Students.FirstOrDefault(s => s.FirstName == "Claudius");
            var alton = context.Students.FirstOrDefault(s => s.FirstName == "Alton");
            var seth = context.Students.FirstOrDefault(s => s.FirstName == "Seth");

            var calc2 = context.Courses.FirstOrDefault(c => c.Code == "MATH217");
            var cSharp = context.Courses.FirstOrDefault(c => c.Code == "COSC100");
            var physics = context.Courses.FirstOrDefault(c => c.Code == "PHYS100");

            if (!claudius.Courses.Any(c => c.CourseId == calc2.Id)) { claudius.Courses.Add(new StudentCourse { CourseId = calc2.Id }); }
            if (!claudius.Courses.Any(c => c.CourseId == physics.Id)) { claudius.Courses.Add(new StudentCourse { CourseId = physics.Id }); }

            if (!alton.Courses.Any(c => c.CourseId == calc2.Id)) { alton.Courses.Add(new StudentCourse { CourseId = calc2.Id }); }
            if (!alton.Courses.Any(c => c.CourseId == cSharp.Id)) { alton.Courses.Add(new StudentCourse { CourseId = cSharp.Id }); }
            if (!alton.Courses.Any(c => c.CourseId == physics.Id)) { alton.Courses.Add(new StudentCourse { CourseId = physics.Id }); }

            if (!seth.Courses.Any(c => c.CourseId == cSharp.Id)) { seth.Courses.Add(new StudentCourse { CourseId = cSharp.Id }); }
            if (!seth.Courses.Any(c => c.CourseId == physics.Id)) { seth.Courses.Add(new StudentCourse { CourseId = physics.Id }); }
        }
    }
}
