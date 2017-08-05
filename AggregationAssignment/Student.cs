using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    class Student
    {
        // Default constructor
        public Student()
        {

        }

        // Constructor with 2 parameters
        public Student(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
