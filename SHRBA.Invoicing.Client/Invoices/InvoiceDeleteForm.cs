using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceDeleteForm : Form
    {
        private readonly IInvoiceService _invoiceService;
        private Invoice _invoice;

        public InvoiceDeleteForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _invoiceService.DeleteInvoice(_invoice);
                var message = "Invoice successfully deleted!" + Environment.NewLine + Environment.NewLine + "Close and reopen the Invoice List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not delete Invoice due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }
    }
}
