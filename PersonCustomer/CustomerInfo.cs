using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonCustomer
{
    public partial class CustomerInfo : Form
    {
        // Property for customer object
        public Customer CustomerData { get; set; }
        public CustomerInfo()
        {
            InitializeComponent();
        }
        // Filling out the form on load
        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            // Showing information about a customer on load from what was entered by a user
            numberLabel.Text = CustomerData.CustomerNumber.ToString();
            fullNameLabel.Text = CustomerData.Name + " " + CustomerData.LastName;
            addressLabel.Text = CustomerData.Address;
            phoneLabel.Text = CustomerData.Phone;

            // Initializing a variable message 
            string message = "";

            // Checking if customer chose to be on a mailing list
            if (CustomerData.MailingList)
            {
                message = "Customer is subscribed to a mailing list.";
            }
            else {
                message = "Customer is not subscribed to a mailing list.";
            }

            mailingLabel.Text = message;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
