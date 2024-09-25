using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Customer;

namespace SHRBA.Invoicing.Core.Services
{
    public interface ICustomerService
    {
        public List<CustomerSummary> GetCustomers();

        public CustomerInfo GetCustomerById(int id);

        public Customer CreateCustomer(CustomerCreate customer);

        public void DeleteCustomer(int customerId);

        public void UpdateCustomer(CustomerInfo customerInfo);


    }
}
