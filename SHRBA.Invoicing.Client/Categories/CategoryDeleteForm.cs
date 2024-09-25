using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Categories
{
    public partial class CategoryDeleteForm : Form
    {
        private readonly ICategoryService _categoryService;
        private int _categoryId;
        public CategoryDeleteForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CategoryDeleteForm_Load(object sender, EventArgs e)
        {


        }

        public void SetCategory(int categoryId)
        {
            _categoryId = categoryId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.DeleteCategory(_categoryId);
                var message = "Category successfully deleted!" + Environment.NewLine + Environment.NewLine + "Close and reopen the category List form to see the changes";
                MessageBox.Show(message, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                var errMessage = "Could not delete category due to: " + Environment.NewLine;
                errMessage += ex.Message + Environment.NewLine + ex.InnerException?.Message;
                MessageBox.Show(errMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
