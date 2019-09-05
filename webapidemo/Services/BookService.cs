using System.Collections.Generic;

namespace webapidemo.Controllers
{
    public class BookService : IBook
    {
        BookStore bookStore;

        public BookService()
        {
            bookStore = new BookStore();
        }

        public Book CreateBook(Book book)
        {
            //string message = Validator.ValidateBook(book);
            //if (message != "")
            //    return message;

            return bookStore.AddBook(book);
        }

        public bool DeleteBook(int bookId)
        {
            return bookStore.DeleteBook(bookId);
        }

        public Book GetBook(int bookId)
        {
            //if (bookId < 0)
            //    return "Invalid bookId, bookId should be a positive number.";
            return bookStore.GetBook(bookId);
        }

        public List<Book> GetBooks()
        {
            return bookStore.GetBooks();
        }

        public Book UpdateBook(int bookId, Book book)
        {
            return bookStore.UpdateBook(bookId, book);
        }
    }
}