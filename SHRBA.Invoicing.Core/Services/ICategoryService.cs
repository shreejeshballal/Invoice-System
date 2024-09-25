using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Category;

namespace SHRBA.Invoicing.Core.Services
{
    public interface ICategoryService
    {
        public List<CategorySummary> GetCategories();

        public CategoryInfo GetCategoryById(int id);

        public Category GetCategoryByProductId(int id);

        public Category CreateCategory(CategoryCreate category);

        public void DeleteCategory(int categoryId);

        public void UpdateCategory(CategoryInfo category);



    }
}
