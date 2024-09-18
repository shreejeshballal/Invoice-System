using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SHRBA.Invoicing.Client;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{

    public partial class InvoiceAddForm : Form
    {
        private Invoice newInvoice;
        //private readonly IUnitOfWork unitOfWork;
        private readonly IInvoiceService invoiceService;
        private readonly ICustomerService customerService;
        private bool IsLoading;

        public InvoiceAddForm(IInvoiceService invoiceService, ICustomerService customerService)
        {


            InitializeComponent();
            //this.unitOfWork = unitOfWork;
            this.invoiceService = invoiceService;
            this.customerService = customerService;
        }



        private void InvoiceAddForm_Load(object sender, EventArgs e)
        {
            newInvoice = new Invoice();
            FillCustomers();

            newInvoice.InvoiceDate = dtInvoiceDate.Value;
            newInvoice.CustomerId = int.Parse(cmbCustomer.SelectedValue.ToString());
            newInvoice.PaymentMode = cmbPaymentMode.Text;
            newInvoice.IsDiscountInPercentage = chkIsPercentage.Checked;
        }

        private void FillCustomers()
        {
            IsLoading = true;
            cmbCustomer.DataSource = customerService.GetCustomers();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
            IsLoading = false;
        }

        private void btnAddLineItem_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<InvoiceLineItemAddForm>();
            form.NewInvoice = newInvoice;
            if (form.ShowDialog() == DialogResult.Cancel) return;

            FillLineItems();
        }
        private void FillLineItems()
        {
            dgvLineItems.DataSource = null;
            dgvLineItems.DataSource = newInvoice.LineItems;

        }
        private void txtInvoiceNumber_TextChanged(object sender, EventArgs e)
        {
            newInvoice.InvoiceNumber = txtInvoiceNumber.Text.Trim();

        }

        private void dtInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            newInvoice.InvoiceDate = dtInvoiceDate.Value;

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            newInvoice.CustomerId = int.Parse(cmbCustomer.SelectedValue.ToString());
        }

        private void cmbPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            newInvoice.PaymentMode = cmbPaymentMode.Text.Trim();
        }

        private void chkIsPercentage_CheckedChanged(object sender, EventArgs e)
        {
            newInvoice.IsDiscountInPercentage = chkIsPercentage.Checked;

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            newInvoice.Discount = double.Parse(txtDiscountAmount.Text.Trim());
            try
            {
                newInvoice.Discount = InputHelper.CheckIsNumeric<double>(txtDiscountAmount.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newInvoice.Discount = 0;
                txtDiscountAmount.Text = "0";
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                var InvoiceNumber = SaveInvoice();
                var message = "Invoice has been saved. (Invoice # " + InvoiceNumber + Environment.NewLine + Environment.NewLine + "Close and reopen the Invoice List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save Inovice due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveInvoice()
        {
            var Invoice = invoiceService.CreateInvoice(newInvoice);
            return Invoice.InvoiceNumber;
        }

        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(newInvoice.InvoiceNumber))
                errors.AppendLine("Invoice Number can't be blank");
            if (newInvoice.IsDiscountInPercentage && newInvoice.Discount == 0)
                errors.AppendLine("Invalid Discount Amount");
            if (string.IsNullOrEmpty(newInvoice.PaymentMode))
                errors.AppendLine("Add a payment mode");
            if (newInvoice.LineItems.Count == 0)
            {
                errors.AppendLine("Add atleast one Line Item");
            }
            return errors.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
