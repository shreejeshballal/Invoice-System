using SHRBA.Invoicing.Core.Models.LineItem;

namespace SHRBA.Invoicing.Core.Models.Invoice
{
    public class InvoiceInfo
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public bool IsDiscountInPercentage { get; set; }
        public double Discount { get; set; }

        public double Total { get; set; }
        public string PaymentMode { get; set; }

        public List<LineItemInfo> LineItems { get; set; } = new List<LineItemInfo>();
    }
}
