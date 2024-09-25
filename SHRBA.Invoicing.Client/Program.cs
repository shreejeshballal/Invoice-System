using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Services;
using SHRBA.Invoicing.Data;
using SHRBA.Invoicing.Services;
using SHRBA.Invoicing.WinClient;
using SHRBA.Invoicing.WinClient.Categories;
using SHRBA.Invoicing.WinClient.Customers;
using SHRBA.Invoicing.WinClient.Invoices;
using SHRBA.Invoicing.WinClient.Products;

namespace SHRBA.Invoicing.Client
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(new MainForm());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var builder = new ConfigurationBuilder();


            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();
            string connectionString = config["ConnectionStrings:Default"];

            return Host.CreateDefaultBuilder().ConfigureServices(
                 (hostContext, services) =>
                 {
                     services.AddDbContext<InvoicingDbContext>(
                         (hcontext, options) =>
                         {
                             options.UseSqlServer(connectionString,
                                                   x => x.MigrationsAssembly("SHRBA.Invoicing.Data"));

                         });

                     services.AddScoped<IUnitOfWork, UnitOfWork>();
                     services.AddTransient<ICategoryService, CategoryService>();
                     services.AddTransient<IProductService, ProductService>();
                     services.AddTransient<ICustomerService, CustomerService>();
                     services.AddTransient<IInvoiceService, InvoiceService>();

                     services.AddTransient<CategoryListForm>();
                     services.AddTransient<ProductListForm>();
                     services.AddTransient<CustomerListForm>();
                     services.AddTransient<InvoiceListForm>();
                     services.AddTransient<InvoiceDetailsForm>();
                     services.AddTransient<InvoiceAddForm>();
                     services.AddTransient<InvoiceLineItemAddForm>();
                     services.AddTransient<CustomerAddForm>();
                     services.AddTransient<CategoryAddForm>();
                     services.AddTransient<ProductAddForm>();
                     services.AddTransient<CategoryEditForm>();
                     services.AddTransient<CustomerEditForm>();
                     services.AddTransient<ProductEditForm>();
                     services.AddTransient<InvoiceLineItemEditForm>();
                     services.AddTransient<InvoiceEditForm>();
                     services.AddTransient<CategoryDeleteForm>();
                     services.AddTransient<CustomerDeleteForm>();
                     services.AddTransient<ProductDeleteForm>();
                     services.AddTransient<InvoiceDeleteForm>();
                     services.AddTransient<InvoiceListItemEditAddForm>();

                 });
        }
    }
}

