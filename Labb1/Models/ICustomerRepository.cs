using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
    public interface ICustomerRepository 
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer customer);
        void updateCustomer(Customer customer);
        void deleteCustomer(int id);    

    }
}
