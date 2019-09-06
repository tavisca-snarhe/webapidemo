using System.Collections.Generic;

namespace webapidemo.Controllers
{
    public class BookStore
    {
        private static List<Book> _books = new List<Book>() { new Book() { Id = 121, Name = "Book2", Category = "Ed", Author = "Saurabh Narhe", Price = 123 } };

        public Book AddBook(Book book)
        {
            _books.Add(book);
            return book;
        }

        public Book UpdateBook(int bookId, Book bookToUpdate)
        {
            Book bookToDelete = _books.Find((book) => book.Id == bookId);
            _books.Remove(bookToDelete);
            _books.Add(bookToUpdate);

            return bookToUpdate;
        }

        public bool DeleteBook(int bookId)
        {
            Book bookToDelete = _books.Find((book) => book.Id == bookId);
            return _books.Remove(bookToDelete);
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public Book GetBook(int bookId)
        {
            return _books.Find((book) => book.Id == bookId);
        }
    }
}