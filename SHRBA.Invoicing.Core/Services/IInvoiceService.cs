using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Invoice;
using SHRBA.Invoicing.Core.Models.LineItem;

namespace SHRBA.Invoicing.Core.Services
{
    public interface IInvoiceService
    {
        public List<InvoiceSummary> GetAllInvoices();

        public InvoiceInfo GetInvoiceById(int id);

        public Invoice CreateInvoice(InvoiceCreate newInvoice);

        public void UpdateInvoice(InvoiceInfo invoiceInfo);

        public void DeleteInvoice(int invoiceId);

        double GetLineItemsTotal(int id);

        public List<LineItemSummary> GetLineItems(int id, bool includeProductInfo = false);


    }
}
