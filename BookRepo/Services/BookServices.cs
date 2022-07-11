using BookRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRepo.Services
{
    public class BookServices : IBookServices
    {
        private BookContext _context;

        public BookServices(BookContext context)
        {
            _context = context;
        }
        public List<Book> GetBooks()
        {
            List<Book> books;
            try
            {
                books = _context.Set<Book>().ToList();
            }
            catch(Exception e)
            {
                throw;
            }
            return books;
        }
    }
}
