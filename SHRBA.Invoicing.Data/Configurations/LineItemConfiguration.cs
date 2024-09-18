using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Data.Configurations
{
    public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
    {
        public void Configure(EntityTypeBuilder<LineItem> builder)
        {

            builder.ToTable("LineItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(li => li.Invoice).WithMany(i => i.LineItems).HasForeignKey(x => x.InvoiceId);

        }
    }
}
