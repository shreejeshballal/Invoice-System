
using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Category CreateCategory(Category category)
        {
            if (CategoryExists(category))
            {
                throw new Exception("Category already exists");
            }

            _unitOfWork.Categories.Add(category);
            _unitOfWork.Commit();
            return category;
        }


        private bool CategoryExists(Category newCategory)
        {
            var category = _unitOfWork.Categories.SingleOrDefault(c => c.Name.ToLower() == newCategory.Name.ToLower());
            return category != null;
        }

        public void DeleteCategory(Category category)
        {
            var product = _unitOfWork.Products.GetProductsByCategoryId(category.Id);
            if (product.Count() > 0)
            {
                throw new Exception("Category has products, cannot delete");
            }
            _unitOfWork.Categories.Remove(category);
            _unitOfWork.Commit();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _unitOfWork.Categories.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _unitOfWork.Categories.GetById(id);
        }

        public Category GetCategoryByProductId(int id)
        {
            return null;
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = _unitOfWork.Categories.SingleOrDefault(c => (c.Id != category.Id && c.Name == category.Name));

            if (existingCategory != null)
            {
                throw new Exception("Category already exists");
            }

            var categoryToBeUpdated = _unitOfWork.Categories.GetById(category.Id);
            if (categoryToBeUpdated != null)
            {
                categoryToBeUpdated.Name = category.Name;
                categoryToBeUpdated.Description = category.Description;
            }

            _unitOfWork.Commit();
        }
    }
}
