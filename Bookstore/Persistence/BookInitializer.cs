using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Core.Models;

namespace Bookstore.Persistence
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
                new Book{BookName = "hi", Description = "dw"}
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
          
        }
    }
}