using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Models;
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

        public Invoice CreateInvoice(Invoice newInvoice)
        {
            _unitOfWork.Invoices.Add(newInvoice);
            _unitOfWork.LineItems.AddRange(newInvoice.LineItems);


            _unitOfWork.Commit();
            return newInvoice;
        }

        public void DeleteInvoice(Invoice invoice)
        {
            _unitOfWork.Invoices.Remove(invoice);
            _unitOfWork.Commit();
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _unitOfWork.Invoices.GetAll();
        }

        public Invoice GetInvoiceById(int id)
        {
            return _unitOfWork.Invoices.GetById(id);
        }

        public IEnumerable<LineItem> GetLineItems(int id, bool includeProductInfo = false)
        {
            return _unitOfWork.LineItems.GetInvoiceLineItems(id, includeProductInfo);
        }

        public double GetLineItemsTotal(int id)
        {
            return 0;
        }

        public void UpdateInvoice(Invoice invoice)
        {
            var existingInvoice = _unitOfWork.Invoices.SingleOrDefault(i => (i.Id != invoice.Id && i.InvoiceNumber == invoice.InvoiceNumber));

            if (existingInvoice != null)
            {
                throw new Exception("Invoice already exists");
            }

            var invoiceToBeUpdated = _unitOfWork.Invoices.GetById(invoice.Id);
            if (invoiceToBeUpdated != null)
            {
                invoiceToBeUpdated.InvoiceDate = invoice.InvoiceDate;
                invoiceToBeUpdated.IsDiscountInPercentage = invoice.IsDiscountInPercentage;
                invoiceToBeUpdated.Discount = invoice.Discount;
                invoiceToBeUpdated.CustomerId = invoice.CustomerId;
                invoiceToBeUpdated.PaymentMode = invoice.PaymentMode;
                invoiceToBeUpdated.Total = invoice.Total;
                invoiceToBeUpdated.LineItems.Clear();
                invoiceToBeUpdated.LineItems.AddRange(invoice.LineItems);
            }

            _unitOfWork.Commit();
        }
    }
}
