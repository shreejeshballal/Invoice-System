namespace SHRBA.Invoicing.Core.Entities
{
    public class LineItem
    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }



    }
}
