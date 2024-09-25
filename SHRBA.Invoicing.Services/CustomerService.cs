using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Entities;
using SHRBA.Invoicing.Core.Mappers;
using SHRBA.Invoicing.Core.Models.Customer;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Customer CreateCustomer(CustomerCreate customerCreate)
        {
            var customer = CustomerMapper.ToCustomer(customerCreate);
            _unitOfWork.Customers.Add(customer);
            _unitOfWork.Commit();
            return customer;
        }

        private bool CustomerExists(CustomerCreate newCustomer)
        {
            var customer = _unitOfWork.Customers.SingleOrDefault(c => (c.Phone.ToLower() == newCustomer.Phone.ToLower() || c.Email.ToLower() == newCustomer.Email.ToLower()));
            return customer != null;
        }

        public void DeleteCustomer(int customerId)
        {
            var invoices = _unitOfWork.Invoices.Find(i => i.CustomerId == customerId);
            if (invoices.Count() > 0)
            {
                throw new Exception("Customer has invoices. Cannot delete");
            }

            var customer = _unitOfWork.Customers.GetById(customerId);
            _unitOfWork.Customers.Remove(customer);
            _unitOfWork.Commit();
        }

        public CustomerInfo GetCustomerById(int id)
        {
            var customer = _unitOfWork.Customers.GetById(id);
            var customerInfo = CustomerMapper.ToCustomerInfo(customer);
            return customerInfo;
        }

        public List<CustomerSummary> GetCustomers()
        {
            var customers = _unitOfWork.Customers.GetAll();
            return customers.Select(customer => CustomerMapper.ToCustomerSummary(customer)).ToList();
        }

        public void UpdateCustomer(CustomerInfo customerInfo)
        {
            var existingCustomer = _unitOfWork.Customers.SingleOrDefault(c => (c.Id != customerInfo.Id && (c.Email == customerInfo.Email || c.Phone == customerInfo.Phone)));

            if (existingCustomer != null)
            {
                throw new Exception("Customer already exists");
            }

            var customerToBeUpdated = _unitOfWork.Customers.GetById(customerInfo.Id);
            if (customerToBeUpdated != null)
            {
                customerToBeUpdated.Name = customerInfo.Name;
                customerToBeUpdated.Address = customerInfo.Address;
                customerToBeUpdated.Email = customerInfo.Email;
                customerToBeUpdated.Phone = customerInfo.Phone;
            }
            _unitOfWork.Commit();
        }
    }
}
