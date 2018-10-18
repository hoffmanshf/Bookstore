using Bookstore.Core;
using Bookstore.Core.Repositories;
using Bookstore.Persistence.Repositories;

namespace Bookstore.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookContext _context;

        public UnitOfWork(BookContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public IBookRepository Books { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}