using SHRBA.Invoicing.Core.Models.LineItem;

namespace SHRBA.Invoicing.Core.Models.Invoice
{
    public class InvoiceCreate
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public bool IsDiscountInPercentage { get; set; }
        public double Discount { get; set; }

        public double Total { get; set; }
        public string PaymentMode { get; set; }

        public List<LineItemCreate> LineItems { get; set; } = new List<LineItemCreate>();
    }
}
