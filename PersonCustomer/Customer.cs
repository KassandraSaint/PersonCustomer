using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCustomer
{
    // Creating a Customer class that inherits from a Person class
    public class Customer : Person
    {
        // Boolean property for mailing list
        public bool MailingList { get; set; }
        // Property for CustomerNumber
        public int CustomerNumber { get; }
        // Static Property to increment customer count each time customer is added
        private static int CustomerCounter { get; set; } = 0; 
        // Creating a constructor for a Customer class
        public Customer()
        {
            // Incrementing customer count
            CustomerCounter++;
            // Assigning customer number with the new value with each new customer added
            CustomerNumber = CustomerCounter;
            MailingList = true;
        }
    }
}
