using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Data.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private InvoicingDbContext InvoicingDbContext
        {
            get { return Context as InvoicingDbContext; }
        }
        public InvoiceRepository(DbContext context) : base(context)
        {
        }


    }
}
