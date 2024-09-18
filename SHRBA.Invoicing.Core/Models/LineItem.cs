namespace SHRBA.Invoicing.Core.Models
{
    public class LineItem
    {
        private double amount;

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Amount { get => Product.Price * Quantity; set => amount = value; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public LineItem ShallowCopy()
        {
            return (LineItem)this.MemberwiseClone();
        }

    }
}
