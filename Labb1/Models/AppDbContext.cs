using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBook> CustomerBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer { FirstName = "Anas", LastName = "Qlok", Email = "Anas@qlok.se", CustomerId=1 });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Stäppens krigare", Author = "Conn Iggulden", Avalible = false, BookId=1, ImageUrl = "https://bilder.akademibokhandeln.se/images_akb/9789174130348_383/stappens-krigare" });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 1, BookId = 1, CustomerBookId = 1, LoanDate = new DateTime(2022,08,23), ReturnDate = new DateTime(2022, 10, 22) });

            modelBuilder.Entity<Customer>().HasData(new Customer { FirstName = "Daniel", LastName = "Thulin", Email = "danne@gmail.se", CustomerId = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Azincourt", Author = "Bernard Cornwell", Avalible = false, BookId = 2, ImageUrl= "https://bilder.akademibokhandeln.se/images_akb/9789186615499_383/azincourt" });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 2, BookId = 2, CustomerBookId = 3, LoanDate = new DateTime(2021,09,23), ReturnDate = new DateTime(2022, 11, 27) });
            modelBuilder.Entity<CustomerBook>().HasData(new CustomerBook { CustomerId = 1, BookId = 2, CustomerBookId = 2, LoanDate = DateTime.Now, ReturnDate = new DateTime(2022, 11, 27) });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Omgiven av idioter : hur man förstår dem som inte går att förstå", Author = "Thomas Erikson", Avalible = false, BookId = 3, ImageUrl = "https://s1.adlibris.com/images/43434791/omgiven-av-idioter-hur-man-forstar-dem-som-inte-gar-att-forsta.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { Title = "Boken som inte ville bli läst", Author = "David Sundin", Avalible = false, BookId = 4, ImageUrl = "https://boktugg.imgix.net/9789179750961.jpg?w=400" });


        }
    }
}
