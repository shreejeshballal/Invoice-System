using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private InvoicingDbContext InvoicingDbContext
        {
            get { return Context as InvoicingDbContext; }
        }

        public ProductRepository(DbContext context) : base(context)
        {

        }

        IEnumerable<Product> IProductRepository.GetProductsByCategoryId(int categoryId)
        {
            return InvoicingDbContext.Products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
