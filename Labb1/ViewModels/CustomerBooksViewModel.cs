using Labb1.Models;
using System.Collections.Generic;

namespace Labb1.ViewModels
{
    public class CustomerBooksViewModel
    {
        public IEnumerable<CustomerBook> CustomerBook { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public Customer customers { get; set; }
        //public IEnumerable<Customer> Customers { get; set; }
    }
}
