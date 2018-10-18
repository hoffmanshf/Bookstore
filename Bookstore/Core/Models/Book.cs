using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookstore.Core.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public float FullPrice { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}