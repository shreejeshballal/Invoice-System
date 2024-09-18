using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Core
{
    public interface IUnitOfWork:IDisposable
    {
        public  ICategoryRepository Categories { get;  }
        public IProductRepository Products { get; }

        public ICustomerRepository Customers { get; }

        public ILineItemRepository LineItems { get; }

        public IInvoiceRepository Invoices { get; }

        public int Commit();
    }
}
