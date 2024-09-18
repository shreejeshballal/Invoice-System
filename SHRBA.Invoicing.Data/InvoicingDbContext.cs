
using Microsoft.EntityFrameworkCore;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.Data.Configurations;

namespace SHRBA.Invoicing.Data
{
    public class InvoicingDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<LineItem> LineItems { get; set; }  

        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Invoice> Invoices { get; set; }
        

        public InvoicingDbContext(DbContextOptions<InvoicingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new  ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new LineItemConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
        }

    }
}
