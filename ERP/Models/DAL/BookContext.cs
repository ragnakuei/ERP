using System.Data.Entity;

namespace ERP.Models.DAL
{
    public class BookContext:DbContext
    {
        public BookContext() : base("BookContext") {  }
        public DbSet<Book> Books { get; set; }
    }
}