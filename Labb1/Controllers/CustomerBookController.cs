using Labb1.Models;
using Labb1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            var customerBook = new CustomerBook()
            {
                BookId = id
            };
            IEnumerable<Customer> customers = _appDbContext.Customers.ToList();

            var CustomerViewModel = new CustomerViewModel()
            {
                customers = customers,
                CustomerBook = customerBook,
            };

            return View(CustomerViewModel);
        }
        [HttpPost]
        public IActionResult Create(CustomerViewModel CustomerViewModel)
        {
            var loanDate = CustomerViewModel.CustomerBook.LoanDate=DateTime.Now;
            CustomerViewModel.CustomerBook.ReturnDate= loanDate.AddDays(30);
            _appDbContext.Add(CustomerViewModel.CustomerBook);
            _appDbContext.SaveChanges();

            return View("Checkouted");
        }
    }
}
