using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Models.Customer;

namespace SHRBA.Invoicing.Core.Mappers
{
    public class CustomerMapper
    {
        public static CustomerSummary ToCustomerSummary(Customer customer)
        {
            return new CustomerSummary
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,

            };
        }

        public static Customer ToCustomer(CustomerCreate customerCreate)
        {
            return new Customer
            {
                Name = customerCreate.Name,
                Email = customerCreate.Email,
                Phone = customerCreate.Phone,
                Address = customerCreate.Address,
            };
        }

        public static CustomerInfo ToCustomerInfo(Customer customer)
        {
            return new CustomerInfo
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Address = customer.Address,

            };
        }
    }
}
