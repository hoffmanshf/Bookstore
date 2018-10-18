using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Bookstore.Core.Models;
using Bookstore.Core.Repositories;

namespace Bookstore.Persistence.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookContext context) : base(context)
        {
        }

        public IEnumerable<Book> GetTopSellingBooks(int count)
        {
            return BookContext.Books.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Book> GetBooksWithAuthors(int pageIndex, int pageSize = 10)
        {
            return BookContext.Books
                .Include(c => c.Authors)
                .OrderBy(c => c.BookName)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public BookContext BookContext
        {
            get { return Context as BookContext; }
        }
    }
}