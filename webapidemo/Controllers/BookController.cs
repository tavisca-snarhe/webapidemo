using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webapidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }

        // GET: api/Book
        [HttpGet]
        public List<Book> Get()
        {
            return bookService.GetBooks();
        }

        // GET: api/Book/5
        [HttpGet("{bookId}", Name = "Get")]

        public Book Get(int bookId)
        {
            return bookService.GetBook(bookId);
        }

        // POST: api/Book
        [HttpPost]
        public Book Post([FromBody] Book book)
        {
            return bookService.CreateBook(book);
        }

        // PUT: api/Book/5
        [HttpPut("{bookId}")]
        public Book Put(int bookId, [FromBody] Book book)
        {
            return bookService.UpdateBook(bookId, book);
        }

        // DELETE: api/Book/5
        [HttpDelete("{bookId}")]
        public bool Delete(int bookId)
        {
            return bookService.DeleteBook(bookId);
        }
    }
}
