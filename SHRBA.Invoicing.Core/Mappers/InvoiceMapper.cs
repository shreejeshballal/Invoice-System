using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Invoice;

namespace SHRBA.Invoicing.Core.Mappers
{
    public class InvoiceMapper
    {
        public static InvoiceSummary ToInvoiceSummary(Invoice invoice)
        {
            return new InvoiceSummary
            {
                Id = invoice.Id,
                InvoiceNumber = invoice.InvoiceNumber,
                InvoiceDate = invoice.InvoiceDate,
                IsDiscountInPercentage = invoice.IsDiscountInPercentage,
                Total = invoice.Total,
                CustomerId = invoice.CustomerId,
                PaymentMode = invoice.PaymentMode,
                Discount = invoice.Discount,

            };
        }

        public static Invoice ToInvoice(InvoiceCreate invoiceCreate)
        {
            return new Invoice
            {
                CustomerId = invoiceCreate.CustomerId,
                InvoiceNumber = invoiceCreate.InvoiceNumber,
                InvoiceDate = invoiceCreate.InvoiceDate,
                IsDiscountInPercentage = invoiceCreate.IsDiscountInPercentage,
                Total = invoiceCreate.Total,
                PaymentMode = invoiceCreate.PaymentMode,
                Discount = invoiceCreate.Discount,
                LineItems = invoiceCreate.LineItems.Select(lineItem => LineItemMapper.ToLineItem(lineItem)).ToList()
            };

        }

        public static InvoiceInfo ToInvoiceInfo(Invoice invoice)
        {
            return new InvoiceInfo
            {
                Id = invoice.Id,
                CustomerId = invoice.CustomerId,
                InvoiceNumber = invoice.InvoiceNumber,
                InvoiceDate = invoice.InvoiceDate,
                Discount = invoice.Discount,
                PaymentMode = invoice.PaymentMode,
                IsDiscountInPercentage = invoice.IsDiscountInPercentage,
                Total = invoice.Total,
                LineItems = invoice.LineItems.Select(lineItem => LineItemMapper.ToLineItemInfo(lineItem)).ToList(),
            };
        }
    }
}
