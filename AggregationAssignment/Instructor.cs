using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    class Instructor
    {
        // Default constructor
        public Instructor()
        {

        }

        // Constructor with 3 parameters
        public Instructor(string Name, string Email, string Office)
        {
            this.Name = Name;
            this.Email = Email;
            OfficeLocation = Office;
        }

        // Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string OfficeLocation { get; set; }

        // Methods
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
