using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Data.Repositories
{
    public class LineItemRepository : Repository<LineItem>, ILineItemRepository
    {

        private InvoicingDbContext InvoicingDbContext
        {
            get { return Context as InvoicingDbContext; }
        }

        public LineItemRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<LineItem> GetInvoiceLineItems(int id, bool includeProductInfo = false)
        {
            if (includeProductInfo)
            {
                return InvoicingDbContext.LineItems.Where(li => li.InvoiceId == id).Include(p => p.Product).ToList();

            }
            else
            {

                return InvoicingDbContext.LineItems.Where(li => li.InvoiceId == id).ToList();
            }
        }

        public double GetLineItemTotal(int id)
        {
            return InvoicingDbContext.LineItems.Where(i => i.InvoiceId == id).Sum(li => li.Amount);
        }

        public double GetInvoiceLineTotal(int id)
        {
            throw new NotImplementedException();
        }
    }
}
