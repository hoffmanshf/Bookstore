using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookstore.Core.Repositories;

namespace Bookstore.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}