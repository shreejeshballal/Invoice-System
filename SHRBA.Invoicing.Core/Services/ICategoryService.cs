using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Services
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetCategories();

        public Category GetCategoryById(int id);

        public Category GetCategoryByProductId(int id);

        public Category CreateCategory(Category category);

        public void DeleteCategory(Category category);

        public void UpdateCategory(Category category);

    }
}
