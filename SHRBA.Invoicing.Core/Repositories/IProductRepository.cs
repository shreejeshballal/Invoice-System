using SHRBA.Invoicing.Core.Entities;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}
