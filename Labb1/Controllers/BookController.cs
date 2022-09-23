using Labb1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Labb1.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;


        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View(_bookRepository.GetAllBooks.ToList());
        }
    }
}
