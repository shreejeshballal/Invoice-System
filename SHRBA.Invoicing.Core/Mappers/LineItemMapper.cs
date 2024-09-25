using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.LineItem;

namespace SHRBA.Invoicing.Core.Mappers
{
    public class LineItemMapper
    {
        public static LineItemSummary ToLineItemSummary(LineItem lineItem)
        {
            return new LineItemSummary
            {
                Id = lineItem.Id,
                Amount = lineItem.Amount,
                InvoiceId = lineItem.InvoiceId,
                Price = lineItem.Product.Price,
                ProductName = lineItem.Product.Name,
                Quantity = lineItem.Quantity

            };
        }


        public static LineItem ToLineItem(LineItemCreate lineItemCreate)
        {
            return new LineItem
            {
                Amount = lineItemCreate.Amount,
                ProductId = lineItemCreate.ProductId,
                Quantity = lineItemCreate.Quantity
            };
        }

        public static LineItem ToLineItem(LineItemInfo lineItemInfo)
        {
            return new LineItem
            {
                Id = lineItemInfo.Id,
                InvoiceId = lineItemInfo.InvoiceId,
                Amount = lineItemInfo.Amount,
                ProductId = lineItemInfo.ProductId,
                Quantity = lineItemInfo.Quantity
            };
        }

        public static LineItemInfo ToLineItemInfo(LineItem lineItem)
        {
            return new LineItemInfo
            {
                Id = lineItem.Id,
                Amount = lineItem.Amount,
                InvoiceId = lineItem.InvoiceId,
                Price = lineItem.Product.Price,
                ProductName = lineItem.Product.Name,
                Quantity = lineItem.Quantity,
                ProductId = lineItem.ProductId
            };


        }

    }
}
