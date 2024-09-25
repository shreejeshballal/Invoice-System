using SHRBA.Invoicing.Core.Entities;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface ILineItemRepository : IRepository<LineItem>
    {

        public IEnumerable<LineItem> GetInvoiceLineItems(int id, bool includeProductInfo = false);

        public double GetInvoiceLineTotal(int id);
    }
}
