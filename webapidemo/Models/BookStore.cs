using System.Collections.Generic;

namespace webapidemo.Controllers
{
    public class BookStore
    {
        static List<Book> books = new List<Book>() { new Book() { Id = 121, Name = "Book2", Category = "Ed", Author = "Saurabh Narhe", Price = 123 } };

        public BookStore() { }

        public Book AddBook(Book book)
        {
            books.Add(book);
            return book;
        }

        public Book UpdateBook(int bookId, Book bookToUpdate)
        {
            Book bookToDelete = books.Find((book) => book.Id == bookId);
            books.Remove(bookToDelete);
            books.Add(bookToUpdate);
            return bookToUpdate;
        }

        public bool DeleteBook(int bookId)
        {
            Book bookToDelete = books.Find((book) => book.Id == bookId);
            return books.Remove(bookToDelete);
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int bookId)
        {
            return books.Find((book) => book.Id == bookId);
        }
    }
}