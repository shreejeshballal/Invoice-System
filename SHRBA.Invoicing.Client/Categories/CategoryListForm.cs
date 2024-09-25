using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Categories
{
    public partial class CategoryListForm : Form
    {
        private readonly ICategoryService _categoryService;
        public CategoryListForm(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            var categories = _categoryService.GetCategories();
            dgvCategories.DataSource = categories;
        }
    }
}
