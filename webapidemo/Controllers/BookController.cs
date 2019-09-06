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
        public ActionResult Get()
        {
            return Ok(bookService.GetBooks());
        }

        // GET: api/Book/5
        [HttpGet("{bookId}", Name = "Get")]
        public ActionResult Get(int bookId)
        {
            try
            {
                return Ok(bookService.GetBook(bookId));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // POST: api/Book
        [HttpPost]
        public ActionResult Post([FromBody] Book book)
        {
            try
            {
                return Ok(bookService.CreateBook(book));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // PUT: api/Book/5
        [HttpPut("{bookId}")]
        public ActionResult Put(int bookId, [FromBody] Book book)
        {
            try
            {
                return Ok(bookService.UpdateBook(bookId, book));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // DELETE: api/Book/5
        [HttpDelete("{bookId}")]
        public ActionResult Delete(int bookId)
        {
            try
            {
                return Ok(bookService.DeleteBook(bookId));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }
    }
}
