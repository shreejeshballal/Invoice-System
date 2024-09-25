using SHRBA.Invoicing.Core.Models.Invoice;
using SHRBA.Invoicing.Core.Models.LineItem;
using SHRBA.Invoicing.Core.Models.Product;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceLineItemAddForm : Form
    {

        private LineItemCreate newLineItem;
        public InvoiceCreate NewInvoice { get; set; }
        private bool IsLoading;
        private readonly IProductService productService;

        public InvoiceLineItemAddForm(IProductService productService)
        {
            InitializeComponent();
            this.productService = productService;
        }

        private void InvoiceLineItemAddForm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            cmbProduct.DataSource = productService.GetProducts();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
            IsLoading = false;

            newLineItem = new LineItemCreate();
            var selectedProduct = (ProductSummary)cmbProduct.SelectedItem;
            newLineItem.ProductName = selectedProduct.Name;
            newLineItem.Price = selectedProduct.Price;
            newLineItem.ProductId = selectedProduct.Id;

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            var selectedProduct = (ProductSummary)cmbProduct.SelectedItem;
            newLineItem.ProductName = selectedProduct.Name;
            newLineItem.Price = selectedProduct.Price;
            newLineItem.ProductId = selectedProduct.Id;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newLineItem.Quantity = InputHelper.CheckIsNumeric<int>(txtQuantity.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newLineItem.Quantity = 0;
                txtQuantity.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var itemExists = NewInvoice.LineItems.SingleOrDefault(x => x.ProductId == newLineItem.ProductId);
                if (itemExists != null)
                {
                    throw new Exception("Lineitem already exists");
                }

                newLineItem.Amount = newLineItem.Quantity * newLineItem.Price;
                NewInvoice.LineItems.Add(newLineItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
