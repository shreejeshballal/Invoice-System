using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;
using SHRBA.Invoicing.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceDetailsForm : Form
    {

        private readonly IInvoiceService invoiceService;
        private readonly ICustomerService customerService;

        public InvoiceDetailsForm(ICustomerService customerService, IInvoiceService invoiceService)
        {
            InitializeComponent();
            this.invoiceService = invoiceService;
            this.customerService = customerService;
        }

        public void DislpayInvoiceDetails(Invoice invoice)
        {
            lblCustomer.Text = customerService.GetCustomerById(invoice.CustomerId).Name;
            lblDiscount.Text = invoice.Discount.ToString();
            lblGrandTotal.Text = invoice.Total.ToString();
            lblInvoiceDate.Text = invoice.InvoiceDate.ToString();
            lblInvoiceNumber.Text = invoice.InvoiceNumber;
            lblPaymentMode.Text = invoice.PaymentMode;

            lblSubTotal.Text = invoiceService.GetLineItemsTotal(invoice.Id).ToString();
            lblTax.Text = "";

            dgvLineItems.DataSource = invoiceService.GetLineItems(invoice.Id,true);


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPaymentMode_Click(object sender, EventArgs e)
        {

        }

        private void lblInvoiceNumber_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
