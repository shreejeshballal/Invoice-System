namespace SHRBA.Invoicing.Core.Models.LineItem
{
    public class LineItemCreate
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
