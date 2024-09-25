namespace SHRBA.Invoicing.Core.Models.LineItem
{
    public class LineItemSummary
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }
        public double Amount { get; set; }

    }
}
