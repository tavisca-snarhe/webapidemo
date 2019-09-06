using webapidemo.Controllers;
using Xunit;

namespace webapidemo_Fixtures
{
    public class BookStoreFixture
    {
        [Fact]
        public void CreateBook_should_add_book_into_store_test()
        {
            BookStore bookStore = new BookStore();
            Book book = new Book() { Id = 124, Name = "Test Book", Category = "Edu", Author = "Test Author", Price = 150 };
            bookStore.AddBook(book);

            Assert.True(book == bookStore.GetBook(book.Id));
        }

        [Fact]
        public void UpdateBook_should_update_book_in_store_test()
        {
            BookStore bookStore = new BookStore();
            Book book = new Book() { Id = 123, Name = "Test Book", Category = "Edu", Author = "Test Author", Price = 150 };
            bookStore.AddBook(book);

            Book updatedBook = new Book() { Id = 123, Name = "New Name", Category = "Edu", Author = "Test Author", Price = 150 };
            bookStore.UpdateBook(book.Id, updatedBook);

            Assert.True(updatedBook == bookStore.GetBook(book.Id));
        }

        [Fact]
        public void DeleteBook_should_delete_book_in_store_test()
        {
            BookStore bookStore = new BookStore();
            Book book = new Book() { Id = 12123 , Name = "Test Book", Category = "Edu", Author = "Test Author", Price = 150 };
            bookStore.AddBook(book);
            bookStore.DeleteBook(book.Id);

            Assert.Equal(null, bookStore.GetBook(book.Id));
        }
        
    }
}
