
using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private InvoicingDbContext InvoicingDbContext
        {
            get { return Context as InvoicingDbContext; }
        }

        public CategoryRepository(DbContext context) : base(context)
        {

        }

        public IEnumerable<Category> GetCategoryWithProducts()
        {
            return InvoicingDbContext.Categories
                 .Include(c => c.Products)
                 .ToList();
        }
    }
}
