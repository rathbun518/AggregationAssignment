using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    static class CourseDB
    {
        public static List<Course> GetCourseList()
        {
            // Create Instructor objects
            var instructor1 = new Instructor("Joe Ortiz", "jortiz@cptc.edu", "rm111E");
            var instructor2 = new Instructor("Ken Meerdink", "kmeerdink@cptc.edu", "rm111W");
            var instructor3 = new Instructor("Mark Webster", "mwebster@cptc.edu", "rm107");
            var instructor4 = new Instructor("Bruce Dague", "bdague@cptc.edu", "rm106");

            // Create Student objects
            var student1 = new Student("John", "Doe");
            var student2 = new Student("Jane", "Smith");
            var student3 = new Student("Jesse", "Simmons");
            var student4 = new Student("Eric", "Jones");
            var student5 = new Student("Donna", "Moore");
            var student6 = new Student("Michael", "Adams");

            // Create Course objects & add students to course roster
            var course1 = new Course()
            {
                Number = "CPW 212",
                Title = "Advanced .NET Programming",
                Description = "Learn advanced .NET programming.",
                NumberOfCredits = 5,
                Instructor = instructor1
            };

            course1.Roster.Add(student1);
            course1.Roster.Add(student2);
            course1.Roster.Add(student4);

            var course2 = new Course()
            {
                Number = "CPW 218",
                Title = "C++",
                Description = "Learn C++ programming language.",
                NumberOfCredits = 5,
                Instructor = instructor2
            };

            course2.Roster.Add(student4);
            course2.Roster.Add(student5);
            course2.Roster.Add(student6);

            var course3 = new Course()
            {
                Number = "CPW 225",
                Title = "Web Animation",
                Description = "Learn jQuery for web animations.",
                NumberOfCredits = 5,
                Instructor = instructor3
            };

            course3.Roster.Add(student2);
            course3.Roster.Add(student3);
            course3.Roster.Add(student6);

            var course4 = new Course()
            {
                Number = "CPW 227",
                Title = "Web Development II",
                Description = "Learn PHP/MYSQL for websites.",
                NumberOfCredits = 5,
                Instructor = instructor4
            };

            course4.Roster.Add(student1);
            course4.Roster.Add(student3);
            course4.Roster.Add(student5);

            // Create course list to return
            var courseList = new List<Course>();
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);
            courseList.Add(course4);

            return courseList;
        }
    }
}
