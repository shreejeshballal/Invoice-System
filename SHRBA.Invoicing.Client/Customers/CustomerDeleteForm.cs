﻿using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Customers
{
    public partial class CustomerDeleteForm : Form
    {
        private readonly ICustomerService _customerService;
        private Customer _customer;
        public CustomerDeleteForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.DeleteCustomer(_customer);
                var message = "Customer successfully deleted!" + Environment.NewLine + Environment.NewLine + "Close and reopen the customer List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not delete customer due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }

        private void CustomerDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
