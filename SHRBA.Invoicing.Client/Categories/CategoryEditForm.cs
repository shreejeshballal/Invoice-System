using System.Text;
using SHRBA.Invoicing.Core.Models.Category;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Categories
{
    public partial class CategoryEditForm : Form
    {

        private CategoryInfo _category;

        private ICategoryService _categoryService;

        public CategoryEditForm(ICategoryService categoryService)
        {
            InitializeComponent();
            this._categoryService = categoryService;

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void DisplayCategoryDetails(int categoryId)
        {
            _category = _categoryService.GetCategoryById(categoryId);
            textBox1.Text = _category.Name;
            textBox2.Text = _category.Description;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _category.Name = InputHelper.ConvertToTitleCase(textBox1.Text.Trim());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _category.Description = textBox2.Text.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                var errors = ValidateInputs();
                if (!string.IsNullOrEmpty(errors))
                    throw new Exception(errors);

                SaveInfo();
                var message = "Category updated successfully " + Environment.NewLine + Environment.NewLine + "Close and reopen the category List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not save category due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveInfo()
        {
            _categoryService.UpdateCategory(_category);

        }
        private string ValidateInputs()
        {
            var errors = new StringBuilder();
            if (string.IsNullOrEmpty(_category.Name))
                errors.AppendLine("Name can't be blank");
            if (string.IsNullOrEmpty(_category.Description))
                errors.AppendLine("Description can't be blank");

            return errors.ToString();
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
