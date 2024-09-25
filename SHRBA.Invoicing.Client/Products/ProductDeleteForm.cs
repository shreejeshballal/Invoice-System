using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Products
{
    public partial class ProductDeleteForm : Form
    {

        private readonly IProductService _productService;
        private int _productId;
        public ProductDeleteForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void ProductDeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void SetProduct(int productId)
        {
            _productId = productId;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                _productService.DeleteProduct(_productId);
                var message = "Product successfully deleted!" + Environment.NewLine + Environment.NewLine + "Close and reopen the product List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not delete product due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
