using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Category;

namespace SHRBA.Invoicing.Core.Mappers
{
    public static class CategoryMapper
    {
        public static CategorySummary ToCategorySummary(Category category)
        {
            return new CategorySummary
            {
                Id = category.Id,
                Name = category.Name,

            };
        }


        public static Category ToCategory(CategoryCreate categoryCreate)
        {
            return new Category
            {
                Name = categoryCreate.Name,
                Description = categoryCreate.Description,

            };
        }

        public static Category ToCategory(CategoryInfo categoryInfo)
        {
            return new Category
            {
                Id = categoryInfo.Id,
                Name = categoryInfo.Name,
                Description = categoryInfo.Description,
            };
        }


        public static CategoryInfo ToCategoryInfo(Category category)
        {
            return new CategoryInfo
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };
        }
    }
}
