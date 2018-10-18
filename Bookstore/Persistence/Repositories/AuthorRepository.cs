using System.Data.Entity;
using System.Linq;
using Bookstore.Core.Models;
using Bookstore.Core.Repositories;

namespace Bookstore.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookContext context) : base(context)
        {
        }

        public Author GetAuthorWithBooks(int id)
        {
            return BookContext.Authors.Include(a => a.Book).SingleOrDefault(a => a.BookID == id);
        }

        public BookContext BookContext
        {
            get { return Context as BookContext; }
        }
    }
}