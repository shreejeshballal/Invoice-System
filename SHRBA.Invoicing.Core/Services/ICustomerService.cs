using SHRBA.Invoicing.Core.Models;

namespace SHRBA.Invoicing.Core.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetCustomers();

        public Customer GetCustomerById(int id);

        public Customer CreateCustomer(Customer customer);

        public void DeleteCustomer(Customer customer);

        public void UpdateCustomer(Customer customer);
    }
}
