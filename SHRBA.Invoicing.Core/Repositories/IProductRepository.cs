using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {
        public IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}
