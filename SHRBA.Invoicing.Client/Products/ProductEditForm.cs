using System.Text;
using SHRBA.Invoicing.Core.Models.Product;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Products
{
    public partial class ProductEditForm : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private ProductInfo _product;
        private bool _isLoading = false;

        public ProductEditForm(IProductService productService, ICategoryService categoryService)
        {
            InitializeComponent();
            _productService = productService;
            _categoryService = categoryService;


        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            comboBox1.DataSource = _categoryService.GetCategories();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            _isLoading = false;
        }

        public void DisplayProductDetails(int productId)
        {
            _product = _productService.GetProductById(productId);
            textBox1.Text = _product.Name;
            textBox2.Text = _product.Description;
            textBox3.Text = _product.Quantity.ToString();
            textBox4.Text = _product.Price.ToString();
            comboBox1.SelectedValue = _product.CategoryId;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _product.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _product.Description = textBox2.Text.Trim();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _product.Quantity = InputHelper.CheckIsNumeric<int>(textBox3.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _product.Quantity = 0;
                textBox3.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _product.Price = InputHelper.CheckIsNumeric<double>(textBox4.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _product.Price = 0;
                textBox4.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;
            _product.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                SaveInfo();
                var message = "Product updated successfully " + Environment.NewLine + Environment.NewLine + "Close and reopen the product List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save product due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInfo()
        {
            _productService.UpdateProduct(_product);

        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(_product.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(_product.Description))
                errors.AppendLine("Description can't be blank");
            if (_product.Quantity <= 0)
                errors.AppendLine("Quantity can't be less than 0");
            if (_product.Price <= 0)
                errors.AppendLine("Price can't be less than 0");


            return errors.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
