using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Invoices
{
    public partial class InvoiceLineItemEditForm : Form
    {

        private LineItem _lineItem;
        private bool _isLoading;
        public Invoice Invoice { get; set; }
        private readonly IProductService _productService;

        public InvoiceLineItemEditForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;

        }

        private void InvoiceLineItemEditForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            var selectedProduct = (Product)cmbProduct.SelectedItem;
            _lineItem.Product = selectedProduct;
            _lineItem.ProductId = selectedProduct.Id;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _lineItem.Quantity = InputHelper.CheckIsNumeric<int>(txtQuantity.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _lineItem.Quantity = 0;
                txtQuantity.Text = "0";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var itemExists = Invoice.LineItems.SingleOrDefault(x => x.Id != _lineItem.Id && x.ProductId == _lineItem.ProductId);
                if (itemExists != null)
                {
                    throw new Exception("Lineitem already exists");
                }

                var index = Invoice.LineItems.FindIndex(x => x.Id == _lineItem.Id);
                Invoice.LineItems[index] = _lineItem;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DisplayLineItemDetails(LineItem lineItem)
        {
            _lineItem = lineItem.ShallowCopy();

            _isLoading = true;
            cmbProduct.DataSource = _productService.GetProducts();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";
            _isLoading = false;


            cmbProduct.SelectedValue = lineItem.ProductId;
            txtQuantity.Text = lineItem.Quantity.ToString();
        }
    }
}
