using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SHRBA.Invoicing.Client;
using SHRBA.Invoicing.Core.Models.Invoice;
using SHRBA.Invoicing.Core.Models.LineItem;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceEditForm : Form
    {
        private bool _isLoading;
        private readonly IInvoiceService _invoiceService;
        private readonly ICustomerService _customerService;
        private InvoiceInfo _invoice;

        public InvoiceEditForm(IInvoiceService invoiceService, ICustomerService customerService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _customerService = customerService;
        }

        public void DisplayInvoiceDetails(int invoiceId)
        {
            FillCustomers();

            _invoice = _invoiceService.GetInvoiceById(invoiceId);
            label6.Text = _invoice.InvoiceNumber;
            dtInvoiceDate.Value = _invoice.InvoiceDate;
            cmbCustomer.SelectedItem = _invoice.CustomerId;
            cmbPaymentMode.Text = _invoice.PaymentMode;
            chkIsPercentage.Checked = _invoice.IsDiscountInPercentage;
            txtDiscountAmount.Text = _invoice.Discount.ToString();
            dgvEditLineItems.DataSource = _invoice.LineItems;

        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                SaveInvoice();
                var message = "Invoice has been saved." + Environment.NewLine + Environment.NewLine + "Close and reopen the Invoice List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                var errMessage = "Could not save Inovice due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInvoice()
        {
            _invoiceService.UpdateInvoice(_invoice);

        }

        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(_invoice.InvoiceNumber))
                errors.AppendLine("Invoice Number can't be blank");
            if (_invoice.IsDiscountInPercentage && _invoice.Discount == 0)
                errors.AppendLine("Invalid Discount Amount");
            if (string.IsNullOrEmpty(_invoice.PaymentMode))
                errors.AppendLine("Add a payment mode");
            if (_invoice.LineItems.Count == 0)
            {
                errors.AppendLine("Add atleast one Line Item");
            }
            return errors.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            _invoice.InvoiceDate = dtInvoiceDate.Value;

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            _invoice.CustomerId = int.Parse(cmbCustomer.SelectedValue.ToString());
        }

        private void InvoiceEditForm_Load(object sender, EventArgs e)
        {


        }
        private void FillCustomers()
        {
            _isLoading = true;
            cmbCustomer.DataSource = _customerService.GetCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
            _isLoading = false;
        }

        private void cmbPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _invoice.PaymentMode = cmbPaymentMode.Text.Trim();
        }

        private void chkIsPercentage_CheckedChanged(object sender, EventArgs e)
        {
            _invoice.IsDiscountInPercentage = chkIsPercentage.Checked;

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            _invoice.Discount = double.Parse(txtDiscountAmount.Text.Trim());
            try
            {
                _invoice.Discount = InputHelper.CheckIsNumeric<double>(txtDiscountAmount.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _invoice.Discount = 0;
                txtDiscountAmount.Text = "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<InvoiceListItemEditAddForm>();
            form.NewInvoice = _invoice;
            if (form.ShowDialog() == DialogResult.Cancel) return;

            FillLineItems();
        }
        private void FillLineItems()
        {
            dgvEditLineItems.DataSource = null;
            dgvEditLineItems.DataSource = _invoice.LineItems;

        }

        private void dgvEditLineItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddLineItem_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<InvoiceLineItemEditForm>();

            var selectedLineItem = dgvEditLineItems.SelectedRows[0].DataBoundItem as LineItemInfo;
            form.Invoice = _invoice;
            form.DisplayLineItemDetails(selectedLineItem);

            if (form.ShowDialog() == DialogResult.Cancel) return;

            FillLineItems();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            var selectedLineItem = dgvEditLineItems.SelectedRows[0].DataBoundItem as LineItemInfo;
            _invoice.LineItems.Remove(selectedLineItem);
            FillLineItems();
        }
    }

}
