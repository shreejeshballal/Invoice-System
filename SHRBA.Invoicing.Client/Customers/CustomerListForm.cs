using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Customers
{
    public partial class CustomerListForm : Form
    {
        private readonly ICustomerService customerService;

        public CustomerListForm(ICustomerService customerService)
        {
            InitializeComponent();
            this.customerService = customerService;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            var customers = customerService.GetCustomers();
            dvgCustomers.DataSource = customers;
        }
    }
}
