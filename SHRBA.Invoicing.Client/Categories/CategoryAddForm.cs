using System.Text;
using SHRBA.Invoicing.Core.Models.Category;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Categories
{
    public partial class CategoryAddForm : Form
    {
        private CategoryCreate newCategory;
        private readonly ICategoryService categoryService;


        public CategoryAddForm(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
        }

        private void CategoryAddForm_Load(object sender, EventArgs e)
        {
            newCategory = new CategoryCreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                var categoryId = SaveInfo();
                var message = "Category created successfully with categoryId" + categoryId + Environment.NewLine + Environment.NewLine + "Close and reopen the category List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save category due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int SaveInfo()
        {
            var customer = categoryService.CreateCategory(newCategory);
            return customer.Id;
        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(newCategory.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(newCategory.Description))
                errors.AppendLine("Description can't be blank");

            return errors.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            newCategory.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newCategory.Description = textBox2.Text.Trim();

        }
    }
}
