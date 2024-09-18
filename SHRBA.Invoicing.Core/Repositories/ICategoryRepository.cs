﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        public IEnumerable<Category> GetCategoryWithProducts();


    }
}
