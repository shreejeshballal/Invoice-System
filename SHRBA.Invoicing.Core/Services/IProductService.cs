using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Product;

namespace SHRBA.Invoicing.Core.Services
{
    public interface IProductService
    {
        public List<ProductSummary> GetProducts();

        public ProductInfo GetProductById(int id);

        public Product CreateProduct(ProductCreate product);

        public void DeleteProduct(int productId);

        public void UpdateProduct(ProductInfo product);
    }
}
