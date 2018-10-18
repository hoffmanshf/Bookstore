using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bookstore.Core.Models;

namespace Bookstore.Persistence
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("name=BookContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}