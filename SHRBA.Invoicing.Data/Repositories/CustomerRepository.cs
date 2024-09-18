using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Models;
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
