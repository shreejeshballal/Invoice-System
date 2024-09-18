using System.Text;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Products
{
    public partial class ProductAddForm : Form
    {
        private Product newProduct;
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private bool IsLoading;
        public ProductAddForm(IProductService productService, ICategoryService categoryService)
        {
            InitializeComponent();
            this.productService = productService;
            this.categoryService = categoryService;
        }
        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            comboBox1.DataSource = categoryService.GetCategories();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            IsLoading = false;

            newProduct = new Product();
            newProduct.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newProduct.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newProduct.Description = textBox2.Text.Trim();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                newProduct.Quantity = InputHelper.CheckIsNumeric<int>(textBox3.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newProduct.Quantity = 0;
                textBox3.Text = "0";
            }
        }


        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                newProduct.Price = InputHelper.CheckIsNumeric<double>(textBox4.Text.Trim());

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newProduct.Price = 0;
                textBox4.Text = "0";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            newProduct.CategoryId = int.Parse(comboBox1.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                var productId = SaveInfo();
                var message = "Product created successfully with productId" + productId + Environment.NewLine + Environment.NewLine + "Close and reopen the product List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save product due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int SaveInfo()
        {
            var product = productService.CreateProduct(newProduct);
            return product.Id;
        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(newProduct.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(newProduct.Description))
                errors.AppendLine("Description can't be blank");
            if (newProduct.Quantity <= 0)
                errors.AppendLine("Quantity can't be less than 0");
            if (newProduct.Price <= 0)
                errors.AppendLine("Price can't be less than 0");


            return errors.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
