using System.Collections.Generic;

namespace webapidemo.Controllers
{
    interface IBook
    {
        List<Book> GetBooks();
        Book GetBook(int bookId);
        Book CreateBook(Book book);
        Book UpdateBook(int bookId, Book book);
        bool DeleteBook(int bookId);

    }
}
