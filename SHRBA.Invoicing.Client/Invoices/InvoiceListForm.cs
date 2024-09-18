using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHRBA.Invoicing.Core.Services;
using SHRBA.Invoicing.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceListForm : Form
    {
        private readonly IInvoiceService invoiceService;
        public InvoiceListForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            this.invoiceService = invoiceService;
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            var invoices = invoiceService.GetAllInvoices();
            dgvInvoices.DataSource = invoices;
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
