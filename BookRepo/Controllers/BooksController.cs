using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BookRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly ILogger<BooksController> _logger;
        private readonly Services.IBookServices _bookServices;

        public BooksController(ILogger<BooksController> logger, Services.IBookServices bookServices)
        {
            _logger = logger;
            _bookServices = bookServices;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            try
            {
                var books = _bookServices.GetBooks();
                if (books == null) return NotFound();
                return Ok(books);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex.Message);
                return BadRequest();
            }
        }
    }
}
