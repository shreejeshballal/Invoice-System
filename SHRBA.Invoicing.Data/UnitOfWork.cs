
using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Repositories;
using SHRBA.Invoicing.Data.Repositories;

namespace SHRBA.Invoicing.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InvoicingDbContext _context;
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;
        private ICustomerRepository _customerRepository;
        private ILineItemRepository _lineItemRepository;
        private IInvoiceRepository _invoiceRepository;

        public UnitOfWork(InvoicingDbContext context)
        {
            _context = context;
        }

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICustomerRepository Customers => _customerRepository = _customerRepository ?? new CustomerRepository(_context);

        public ILineItemRepository LineItems => _lineItemRepository = _lineItemRepository ?? new LineItemRepository(_context);

        public IInvoiceRepository Invoices => _invoiceRepository = _invoiceRepository ?? new InvoiceRepository(_context);

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
