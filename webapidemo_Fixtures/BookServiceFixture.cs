using Xunit;
using webapidemo.Controllers;

namespace webapidemo_Fixtures
{
    public class BookServiceFixture
    {
        BookService bookService = new BookService();

        [Fact]
        public void GetBook_should_get_correct_book_test()
        {
            int id = 0;
            Book book = new Book { Id = 0, Name = "The Monk Who sold his Ferrari", Author = "Robin Sharma", Category = "Fiction" };
            bookService.CreateBook(book);
            Assert.True(book == bookService.GetBook(id));
        }

        [Fact]
        public void CreateBook_should_add_book_store_test()
        {
            Book book = new Book { Id = 0, Name = "Monk Who sold his Ferrari", Author = "Robin Sharma", Category = "Fiction" };
            bookService.CreateBook(book);
            Assert.Contains(book, bookService.GetBooks());
        }

        [Fact]
        public void UpdateBook_should_update_book_in_store_test()
        {
            Book book = new Book { Id = 0, Name = "The Monk Who sold his Ferrari", Author = "Robin Sharma", Category = "Fiction" };
            int id = 0;
            bookService.UpdateBook(id, book);
            Assert.Contains(book, bookService.GetBooks());
        }

        [Fact]
        public void DeleteBook_should_delete_book_from_store_test()
        {
            int id = 1;
            Book book = new Book { Id = id, Name = "The Monk Who sold his Ferrari", Author = "Robin Sharma", Category = "Fiction" };
            bookService.CreateBook(book);
            bookService.DeleteBook(id);
            Assert.Null(bookService.GetBook(id));
        }

        [Fact]
        public void GetBook_should_throw_BadRequestException_when_passed_negative_bookId_test()
        {
            int bookId = -123;
            Assert.Throws<BadRequestException>(() => bookService.GetBook(bookId));
        }

        [Fact]
        public void CreateBook_should_throw_BadRequestException_when_passed_invalid_book_test()
        {
            Book book = new Book { Id = -12, Name = "1234", Author = "Robin Sharma", Category = "Fiction" };
            Assert.Throws<BadRequestException>(() => bookService.CreateBook(book));
        }

        [Fact]
        public void DeleteBook_should_throw_BadRequestException_when_passed_negative_bookId_test()
        {
            int bookId = -13;
            Assert.Throws<BadRequestException>(() => bookService.DeleteBook(bookId));
        }

        [Fact]
        public void UpdateBook_should_throw_BadRequestException_when_passed_invalid_book_test()
        {
            int bookId = 121;
            Book book = new Book { Id = 121, Name = "1234", Author = "Robin Sharma", Category = "Fiction" };
            Assert.Throws<BadRequestException>(() => bookService.UpdateBook(bookId, book));
        }
    }
}
