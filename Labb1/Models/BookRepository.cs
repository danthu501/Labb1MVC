using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
    public class BookRepository : IBookRepository
    {

        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> GetAllBooks
        {
            get { return _appDbContext.Books; }
        }


    }
}
