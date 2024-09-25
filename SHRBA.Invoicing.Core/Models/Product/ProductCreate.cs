namespace SHRBA.Invoicing.Core.Models.Product
{
    public class ProductCreate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
