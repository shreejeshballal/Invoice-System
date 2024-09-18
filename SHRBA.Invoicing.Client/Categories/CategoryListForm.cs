using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Categories
{
    public partial class CategoryListForm : Form
    {
        private readonly ICategoryService categoryService;
        public CategoryListForm(ICategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;

        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetCategories();
            dgvCategories.DataSource = categories;
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
