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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Creating GetCustomer method to get customer's information entered by a user
        private void GetCustomer(Customer customer)
        {
            // Getting information entered by the user 
            customer.Name = nameBox.Text;
            customer.LastName = lastNameBox.Text;
            customer.Address = addressBox.Text;
            customer.Phone = phoneBox.Text;
            customer.MailingList = yesCheckBox.Checked;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Creating Customer
            Customer customer = new Customer();
            // Calling GetCustomer method to get data on a customer
            GetCustomer(customer);

            // Creating an instance of the CustomerInfo class
            CustomerInfo customerInfo = new CustomerInfo();
            // Assigning a reference of the Customer to customerInfo form
            customerInfo.CustomerData = customer;
            // Displaying the CustomerInfo form
            customerInfo.ShowDialog();

            // Clearing Add Customer text boxes and setting focus on the first one
            nameBox.Clear();
            lastNameBox.Clear();
            addressBox.Clear();
            phoneBox.Clear();
            yesCheckBox.Checked = false;
            nameBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
