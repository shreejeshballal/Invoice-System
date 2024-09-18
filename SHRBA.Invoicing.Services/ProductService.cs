using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Models;
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

        public Product CreateProduct(Product product)
        {
            if (ProductExists(product))
            {
                throw new Exception("Product already exists in that category");
            }

            _unitOfWork.Products.Add(product);
            _unitOfWork.Commit();
            return product;
        }

        private bool ProductExists(Product newProduct)
        {
            var product = _unitOfWork.Products.SingleOrDefault(c => c.Name.ToLower() == newProduct.Name.ToLower() && c.CategoryId == newProduct.CategoryId);
            return product != null;
        }


        public void DeleteProduct(Product product)
        {
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Commit();
        }

        public Product GetProductById(int id)
        {
            return _unitOfWork.Products.GetById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.Products.GetAll();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _unitOfWork.Products.SingleOrDefault(p => (p.Id != product.Id && (p.Name == product.Name && p.CategoryId == product.CategoryId)));

            if (existingProduct != null)
            {
                throw new Exception("Product already exists");
            }

            var productToBeUpdated = _unitOfWork.Products.GetById(product.Id);
            if (productToBeUpdated != null)
            {
                productToBeUpdated.Price = product.Price;
                productToBeUpdated.Quantity = product.Quantity;
                productToBeUpdated.Description = product.Description;
                productToBeUpdated.Name = product.Name;
                productToBeUpdated.CategoryId = product.CategoryId;
            }
            _unitOfWork.Commit();
        }
    }
}
