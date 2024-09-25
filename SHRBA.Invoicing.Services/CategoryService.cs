
using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Mappers;
using SHRBA.Invoicing.Core.Models.Category;
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

        public Category CreateCategory(CategoryCreate category)
        {
            if (CategoryExists(category))
            {
                throw new Exception("Category already exists");
            }

            var categoryEntity = CategoryMapper.ToCategory(category);

            _unitOfWork.Categories.Add(categoryEntity);
            _unitOfWork.Commit();
            return categoryEntity;
        }


        private bool CategoryExists(CategoryCreate newCategory)
        {
            var category = _unitOfWork.Categories.SingleOrDefault(c => c.Name.ToLower() == newCategory.Name.ToLower());
            return category != null;
        }

        public void DeleteCategory(int categoryId)
        {
            var product = _unitOfWork.Products.GetProductsByCategoryId(categoryId);
            if (product.Count() > 0)
            {
                throw new Exception("Category has products, cannot delete");
            }
            var category = _unitOfWork.Categories.GetById(categoryId);
            _unitOfWork.Categories.Remove(category);
            _unitOfWork.Commit();
        }

        public List<CategorySummary> GetCategories()
        {
            var categories = _unitOfWork.Categories.GetAll();
            return categories.Select(category => CategoryMapper.ToCategorySummary(category)).ToList();

        }

        public CategoryInfo GetCategoryById(int id)
        {
            var category = _unitOfWork.Categories.GetById(id);
            var categoryInfo = CategoryMapper.ToCategoryInfo(category);
            return categoryInfo;
        }

        public Category GetCategoryByProductId(int id)
        {
            return null;
        }

        public void UpdateCategory(CategoryInfo categoryInfo)
        {
            var existingCategory = _unitOfWork.Categories.SingleOrDefault(c => (c.Id != categoryInfo.Id && c.Name == categoryInfo.Name));

            if (existingCategory != null)
            {
                throw new Exception("Category already exists");
            }

            var categoryToBeUpdated = _unitOfWork.Categories.GetById(categoryInfo.Id);

            if (categoryToBeUpdated != null)
            {
                categoryToBeUpdated.Name = categoryInfo.Name;
                categoryToBeUpdated.Description = categoryInfo.Description;
            }

            _unitOfWork.Commit();
        }
    }
}
