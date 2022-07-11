using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookRepo.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

    }

    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }
        DbSet<Book> Books
        {
            get;
            set;
        }
    }
}
