namespace webapidemo.Controllers
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }

        public static bool operator ==(Book book1, Book book2)
        {
            return book1.Id == book2.Id && book1.Name == book2.Name && book1.Category == book2.Category && book1.Author == book2.Author && book1.Price == book2.Price; 
        }

        public static bool operator !=(Book book1, Book book2)
        {
            return book1.Id != book2.Id || book1.Name != book2.Name || book1.Category != book2.Category || book1.Author != book2.Author || book1.Price != book2.Price;
        }
    }
}