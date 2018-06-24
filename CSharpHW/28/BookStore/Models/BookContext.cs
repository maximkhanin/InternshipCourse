using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Book1", Author = "Author1", Price = 100, Id = 001 });
            db.Books.Add(new Book { Name = "Book2", Author = "Author2", Price = 200, Id = 002 });
            db.Books.Add(new Book { Name = "Book3", Author = "Author3", Price = 300, Id = 003 });

            base.Seed(db);
        }
    }
}