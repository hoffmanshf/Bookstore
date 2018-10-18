using Bookstore.Core.Models;

namespace Bookstore.Core.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithBooks(int id);
    }
}
