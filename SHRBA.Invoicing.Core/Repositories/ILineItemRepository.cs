using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface ILineItemRepository:IRepository<LineItem>
    {

        public IEnumerable<LineItem> GetInvoiceLineItems(int id, bool includeProductInfo =false);

        public double GetInvoiceLineTotal(int id);  
    }
}
