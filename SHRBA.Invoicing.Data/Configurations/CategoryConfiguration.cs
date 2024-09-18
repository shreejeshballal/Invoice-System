
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.
               ToTable("Categories");

            builder.
                HasKey(c => c.Id);

            builder.
                Property(c => c.Id)
                .UseIdentityColumn();

            builder.
                Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

        }

    }
}
