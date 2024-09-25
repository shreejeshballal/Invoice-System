using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Mappers;
using SHRBA.Invoicing.Core.Models.Invoice;
using SHRBA.Invoicing.Core.Models.LineItem;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.Services
{
    public class InvoiceService : IInvoiceService
    {


        private readonly IUnitOfWork _unitOfWork;

        public InvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Invoice CreateInvoice(InvoiceCreate newInvoice)
        {
            var invoice = InvoiceMapper.ToInvoice(newInvoice);
            _unitOfWork.Invoices.Add(invoice);
            _unitOfWork.Commit();
            return invoice;
        }

        public void DeleteInvoice(int invoiceId)
        {
            var invoice = _unitOfWork.Invoices.GetById(invoiceId);

            _unitOfWork.Invoices.Remove(invoice);
            _unitOfWork.Commit();
        }

        public List<InvoiceSummary> GetAllInvoices()
        {
            var invoices = _unitOfWork.Invoices.GetAll();
            return invoices.Select(invoice => InvoiceMapper.ToInvoiceSummary(invoice)).ToList();
        }

        public InvoiceInfo GetInvoiceById(int id)
        {
            var invoice = _unitOfWork.Invoices.GetById(id);
            var lineItems = _unitOfWork.LineItems.GetInvoiceLineItems(id, true).ToList();
            invoice.LineItems = lineItems;
            var invoiceInfo = InvoiceMapper.ToInvoiceInfo(invoice);
            return invoiceInfo;
        }

        public List<LineItemSummary> GetLineItems(int id, bool includeProductInfo = false)
        {
            var lineItems = _unitOfWork.LineItems.GetInvoiceLineItems(id, includeProductInfo);
            return lineItems.Select(lineItem => LineItemMapper.ToLineItemSummary(lineItem)).ToList();

        }

        public double GetLineItemsTotal(int id)
        {
            return 0;
        }

        public void UpdateInvoice(InvoiceInfo invoiceInfo)
        {
            var existingInvoice = _unitOfWork.Invoices.SingleOrDefault(i => (i.Id != invoiceInfo.Id && i.InvoiceNumber == invoiceInfo.InvoiceNumber));

            if (existingInvoice != null)
            {
                throw new Exception("Invoice already exists");
            }

            var invoiceToBeUpdated = _unitOfWork.Invoices.GetById(invoiceInfo.Id);
            if (invoiceToBeUpdated != null)
            {
                invoiceToBeUpdated.InvoiceDate = invoiceInfo.InvoiceDate;
                invoiceToBeUpdated.IsDiscountInPercentage = invoiceInfo.IsDiscountInPercentage;
                invoiceToBeUpdated.Discount = invoiceInfo.Discount;
                invoiceToBeUpdated.CustomerId = invoiceInfo.CustomerId;
                invoiceToBeUpdated.PaymentMode = invoiceInfo.PaymentMode;
                invoiceToBeUpdated.Total = invoiceInfo.Total;
                invoiceToBeUpdated.LineItems = invoiceInfo.LineItems.Select(lineItem => LineItemMapper.ToLineItem(lineItem)).ToList();
            }

            _unitOfWork.Commit();
        }
    }
}
