using System.Text;
using System.Text.RegularExpressions;
using SHRBA.Invoicing.Core.Models.Customer;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Customers
{
    public partial class CustomerEditForm : Form
    {

        private CustomerInfo _customer;
        private readonly ICustomerService _customerService;

        public CustomerEditForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;

        }

        public void DisplayCustomerDetails(int customerId)
        {
            _customer = _customerService.GetCustomerById(customerId);
            textBox1.Text = _customer.Name;
            textBox2.Text = _customer.Address;
            textBox3.Text = _customer.Phone;
            textBox4.Text = _customer.Email;
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _customer.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _customer.Address = textBox2.Text.Trim();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _customer.Phone = textBox3.Text.Trim();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            _customer.Email = textBox4.Text.Trim();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                SaveInfo();
                var message = "Customer updated successfully " + Environment.NewLine + Environment.NewLine + "Close and reopen the customer List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save customer due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInfo()
        {
            _customerService.UpdateCustomer(_customer);
        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(_customer.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(_customer.Phone))
                errors.AppendLine("Phone can't be blank");
            else if (!Regex.IsMatch(_customer.Phone, @"^\d{10}$")) // Assuming phone number should be 10 digits
                errors.AppendLine("Phone number must be 10 digits");
            if (string.IsNullOrEmpty(_customer.Address))
                errors.AppendLine("Address can't be blank");
            if (string.IsNullOrEmpty(_customer.Email))
                errors.AppendLine("Email can't be blank");
            else if (!Regex.IsMatch(_customer.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Basic email format check
                errors.AppendLine("Invalid email format");


            return errors.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
