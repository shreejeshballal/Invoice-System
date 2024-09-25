using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Repositories;

namespace SHRBA.Invoicing.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        private InvoicingDbContext InvoicingDbContext
        {
            get { return Context as InvoicingDbContext; }
        }

        public CustomerRepository(DbContext context) : base(context)
        {
        }


    }
}
