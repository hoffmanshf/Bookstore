using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Core.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        public int BookID { get; set; }

        public string Name { get; set; }

        public virtual Book Book { get; set; }
    }
}