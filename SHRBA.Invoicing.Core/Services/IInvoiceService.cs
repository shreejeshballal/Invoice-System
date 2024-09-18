using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Services
{
    public interface IInvoiceService
    {
        public IEnumerable<Invoice> GetAllInvoices();

        public Invoice GetInvoiceById(int id);

        public Invoice CreateInvoice(Invoice newInvoice);

        public void UpdateInvoice(Invoice invoice);

        public void DeleteInvoice(Invoice invoice);

        double GetLineItemsTotal(int id);

        public IEnumerable<LineItem> GetLineItems(int id, bool includeProductInfo = false);


    }
}
