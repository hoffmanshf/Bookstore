using System.Collections.Generic;
using Bookstore.Core.Models;

namespace Bookstore.Core.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetTopSellingBooks(int count);
        IEnumerable<Book> GetBooksWithAuthors(int pageIndex, int pageSize);
    }
}