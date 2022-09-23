using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Labb1.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void CreateCustomer(Customer customer)
        {

            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _appDbContext.Customers;
            }
        }


        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
        }

        public void updateCustomer(Customer customer)
        {
            _appDbContext.Update(customer);
            _appDbContext.SaveChanges();
        }

        public void deleteCustomer(int id)
        {
            Customer customer = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChanges();    
        }
    }
}
