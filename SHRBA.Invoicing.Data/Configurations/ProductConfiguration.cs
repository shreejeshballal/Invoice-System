using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.
                HasKey(p => p.Id);

            builder.
                Property(p => p.Id)
                .UseIdentityColumn();

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(250);

            builder
               .Property(p => p.Quantity)
               .IsRequired();

            builder
                .Property(p => p.Price)
                .IsRequired();

            builder.
                ToTable("Products");

            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);

        }
    }
}
