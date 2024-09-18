namespace SHRBA.Invoicing.Core.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }

        public bool IsDiscountInPercentage { get; set; }
        public double Discount { get; set; }

        public double Total { get; set; }
        public string PaymentMode { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<LineItem> LineItems = new List<LineItem>();

    }
}
