using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();

        public Product GetProductById(int id);

        public Product CreateProduct(Product product);

        public void DeleteProduct(Product product);

        public void UpdateProduct(Product product);
    }
}
