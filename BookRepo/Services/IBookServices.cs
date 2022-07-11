using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRepo.Services
{
    public interface IBookServices
    {
        List<Models.Book> GetBooks();
    }
}
