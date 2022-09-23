using Labb1.Models;
using Labb1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace Labb1.Controllers
{
    public class CustomerBookController : Controller
    {


        private readonly AppDbContext _appDbContext;
        public CustomerBookController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Loan(int id)
        {

            var customer = _appDbContext.Customers.FirstOrDefault(i => i.CustomerId ==id);
            IEnumerable<CustomerBook> customerBooks = _appDbContext.CustomerBooks.Where(f => f.CustomerId ==id).ToList();
            IEnumerable<Book> books = _appDbContext.Books.ToList();
            

            var CustomerBooksViewModel = new CustomerBooksViewModel
            {
                customers = customer,
                CustomerBook = customerBooks,
                Books = books
            };
            return View(CustomerBooksViewModel);


        }

        public IActionResult Create(int id)
        {
            var test = new CustomerBook()
            {
                BookId = id
            };
            return View(test);
        }
        [HttpPost]
        public IActionResult Create(CustomerBook customerBook)
        {
            var loanDate  = customerBook.LoanDate=DateTime.Now;
            customerBook.ReturnDate= loanDate.AddDays(30);
            _appDbContext.CustomerBooks.Add(customerBook);
            _appDbContext.SaveChanges();

            return View();
        }
    }
}
