using System.Text;
using System.Text.RegularExpressions;
using SHRBA.Invoicing.Core.Models.Customer;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Customers
{
    public partial class CustomerAddForm : Form
    {
        private CustomerCreate newCustomer;
        private readonly ICustomerService customerService;
        public CustomerAddForm(ICustomerService customerService)
        {
            InitializeComponent();
            this.customerService = customerService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                var customerId = SaveInfo();
                var message = "Customer created successfully with customerId" + customerId + Environment.NewLine + Environment.NewLine + "Close and reopen the customer List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save customer due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int SaveInfo()
        {
            var customer = customerService.CreateCustomer(newCustomer);
            return customer.Id;
        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(newCustomer.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(newCustomer.Phone))
                errors.AppendLine("Phone can't be blank");
            else if (!Regex.IsMatch(newCustomer.Phone, @"^\d{10}$")) // Assuming phone number should be 10 digits
                errors.AppendLine("Phone number must be 10 digits");
            if (string.IsNullOrEmpty(newCustomer.Address))
                errors.AppendLine("Address can't be blank");
            if (string.IsNullOrEmpty(newCustomer.Email))
                errors.AppendLine("Email can't be blank");
            else if (!Regex.IsMatch(newCustomer.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Basic email format check
                errors.AppendLine("Invalid email format");


            return errors.ToString();
        }


        private void CustomerAddForm_Load(object sender, EventArgs e)
        {

            newCustomer = new CustomerCreate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newCustomer.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newCustomer.Address = textBox2.Text.Trim();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            newCustomer.Phone = textBox3.Text.Trim();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            newCustomer.Email = textBox4.Text.Trim();

        }
    }
}
