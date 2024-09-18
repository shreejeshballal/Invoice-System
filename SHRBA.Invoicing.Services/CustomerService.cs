using SHRBA.Invoicing.Core;
using SHRBA.Invoicing.Core.Models;
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

        public Customer CreateCustomer(Customer customer)
        {
            if (CustomerExists(customer))
            {
                throw new Exception("Customer already exists");
            }

            _unitOfWork.Customers.Add(customer);
            _unitOfWork.Commit();
            return customer;
        }

        private bool CustomerExists(Customer newCustomer)
        {
            var customer = _unitOfWork.Customers.SingleOrDefault(c => (c.Phone.ToLower() == newCustomer.Phone.ToLower() || c.Email.ToLower() == newCustomer.Email.ToLower()));
            return customer != null;
        }

        public void DeleteCustomer(Customer customer)
        {
            _unitOfWork.Customers.Remove(customer);
            _unitOfWork.Commit();
        }

        public Customer GetCustomerById(int id)
        {
            return _unitOfWork.Customers.GetById(id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _unitOfWork.Customers.GetAll();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _unitOfWork.Customers.SingleOrDefault(c => (c.Id != customer.Id && (c.Email == customer.Email || c.Phone == customer.Phone)));

            if (existingCustomer != null)
            {
                throw new Exception("Customer already exists");
            }

            var customerToBeUpdated = _unitOfWork.Customers.GetById(customer.Id);
            if (customerToBeUpdated != null)
            {
                customerToBeUpdated.Name = customer.Name;
                customerToBeUpdated.Address = customer.Address;
                customerToBeUpdated.Email = customer.Email;
                customerToBeUpdated.Phone = customer.Phone;
            }
            _unitOfWork.Commit();
        }
    }
}
