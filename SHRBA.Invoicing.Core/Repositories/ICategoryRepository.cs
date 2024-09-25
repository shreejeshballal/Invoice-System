using SHRBA.Invoicing.Core.Entities;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> GetCategoryWithProducts();


    }
}
