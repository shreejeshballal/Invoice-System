using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Product;

namespace SHRBA.Invoicing.Core.Mappers
{
    public static class ProductMapper
    {
        public static ProductSummary ToProductSummary(Product product)
        {
            return new ProductSummary
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,

            };
        }

        public static Product ToProduct(ProductCreate productCreate)
        {
            return new Product
            {
                Name = productCreate.Name,
                Price = productCreate.Price,
                Quantity = productCreate.Quantity,
                CategoryId = productCreate.CategoryId,
                Description = productCreate.Description,
            };
        }

        public static ProductInfo ToProductInfo(Product product)
        {
            return new ProductInfo
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                Description = product.Description,
            };
        }

    }
}
