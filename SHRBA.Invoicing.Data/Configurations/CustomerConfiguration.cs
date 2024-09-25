using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHRBA.Invoicing.Core.Entities;

namespace SHRBA.Invoicing.Data.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

        }
    }
}
