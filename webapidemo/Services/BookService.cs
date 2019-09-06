using System;
using System.Collections.Generic;

namespace webapidemo.Controllers
{
    public class BookService : IBook
    {
        private BookStore _bookStore;

        public BookService()
        {
            _bookStore = new BookStore();
        }

        public Book CreateBook(Book book)
        {
            if(!Validator.IsValidBook(book, out string error))
                throw new BadRequestException(error);

            return _bookStore.AddBook(book);
        }

        public bool DeleteBook(int bookId)
        {
            if (!Validator.IsValidBookId(bookId, out string error))
                throw new BadRequestException(error);

            return _bookStore.DeleteBook(bookId);
        }

        public Book GetBook(int bookId)
        {
            if(!Validator.IsValidBookId(bookId, out string error))
                throw new BadRequestException(error);

            return _bookStore.GetBook(bookId);
        }

        public List<Book> GetBooks()
        {
            return _bookStore.GetBooks();
        }

        public Book UpdateBook(int bookId, Book book)
        {
            string error = "";
            if (!Validator.IsValidBookId(bookId, out string invalidBookId))
                error += invalidBookId + Environment.NewLine;
            if (!Validator.IsValidBook(book, out string invalidBook))
                error += invalidBook;

            if (error != "")
                throw new BadRequestException(error);

            return _bookStore.UpdateBook(bookId, book);
        }
    }
}