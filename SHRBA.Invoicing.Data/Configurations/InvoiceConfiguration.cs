using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHRBA.Invoicing.Core.Entities;

namespace SHRBA.Invoicing.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder
               .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .UseIdentityColumn();

            builder
                .Property(c => c.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .ToTable("Invoices")
                .HasIndex(i => i.InvoiceNumber);

            builder
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId);

        }
    }
}
