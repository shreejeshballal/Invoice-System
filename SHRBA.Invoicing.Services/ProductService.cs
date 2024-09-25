using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Mappers;
using SHRBA.Invoicing.Core.Models.Product;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.Services
{
    public class ProductService : IProductService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Product CreateProduct(ProductCreate productCreate)
        {
            if (ProductExists(productCreate))
            {
                throw new Exception("Product already exists in that category");
            }

            var product = ProductMapper.ToProduct(productCreate);

            _unitOfWork.Products.Add(product);
            _unitOfWork.Commit();
            return product;
        }

        private bool ProductExists(ProductCreate newProduct)
        {
            var product = _unitOfWork.Products.SingleOrDefault(c => c.Name.ToLower() == newProduct.Name.ToLower() && c.CategoryId == newProduct.CategoryId);
            return product != null;
        }


        public void DeleteProduct(int productId)
        {
            var invoices = _unitOfWork.LineItems.Find(i => i.ProductId == productId);

            if (invoices.Count() > 0)
            {
                throw new Exception("Product are used in invoices. Cannot delete");
            }
            var product = _unitOfWork.Products.GetById(productId);
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Commit();
        }

        public ProductInfo GetProductById(int id)
        {
            var product = _unitOfWork.Products.GetById(id);
            var productInfo = ProductMapper.ToProductInfo(product);
            return productInfo;
        }

        public List<ProductSummary> GetProducts()
        {
            var products = _unitOfWork.Products.GetAll();
            return products.Select(product => ProductMapper.ToProductSummary(product)).ToList();
        }

        public void UpdateProduct(ProductInfo productInfo)
        {
            var existingProduct = _unitOfWork.Products.SingleOrDefault(p => (p.Id != productInfo.Id && (p.Name == productInfo.Name && p.CategoryId == productInfo.CategoryId)));

            if (existingProduct != null)
            {
                throw new Exception("Product already exists");
            }

            var productToBeUpdated = _unitOfWork.Products.GetById(productInfo.Id);

            if (productToBeUpdated != null)
            {
                productToBeUpdated.Price = productInfo.Price;
                productToBeUpdated.Quantity = productInfo.Quantity;
                productToBeUpdated.Description = productInfo.Description;
                productToBeUpdated.Name = productInfo.Name;
                productToBeUpdated.CategoryId = productInfo.CategoryId;
            }
            _unitOfWork.Commit();
        }
    }
}
