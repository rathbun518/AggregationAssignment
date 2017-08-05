using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    class Course
    {
        // Default constructor
        public Course()
        {
            Roster = new List<Student>();
        }

        // Properties
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfCredits { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> Roster { get; set; }

        // Methods
        public Instructor getInstructor()
        {
            return Instructor;
        }

        public List<Student> LoadRoster()
        {
            return Roster;
        }

        public override string ToString()
        {
            return $"{Number}";
        }

    }
}
