using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Layout_Test.Models.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext") { }
        public DbSet<Book> Books { get; set; }
    }
}