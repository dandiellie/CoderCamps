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
            var physics = context.Courses.FirstOrDefault(c => c.Code == "COSC100");

            claudius.Courses.Add(calc2);
            claudius.Courses.Add(physics);

            alton.Courses.Add(calc2);
            alton.Courses.Add(cSharp);
            alton.Courses.Add(physics);

            seth.Courses.Add(cSharp);
            seth.Courses.Add(physics);

            context.SaveChanges();
        }
    }
}
