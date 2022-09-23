using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
    public class CustomerBook
    {
        public int CustomerBookId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}")]
        public DateTime LoanDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}")]
        public DateTime ReturnDate { get; set; }
    }
}
