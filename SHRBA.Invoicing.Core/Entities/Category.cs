﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace SHRBA.Invoicing.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public IEnumerable<Product> Products { get; set; }

    }
}
