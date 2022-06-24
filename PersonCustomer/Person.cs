using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCustomer
{
    // Creating a base class Person
    public class Person
    {
        // Creating a constructor for a Person class
        public Person()
        {
            Name = "";
            LastName = "";
            Address = "";
            Phone = "";

        }
        // Properties for a Person with getters and setters
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
