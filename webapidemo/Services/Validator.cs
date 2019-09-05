using System.Text.RegularExpressions;

namespace webapidemo.Controllers
{
    public static class Validator
    {
        public static string ValidateBook(Book book)
        {
            string responseMessage = "";

            if (book.Id < 0)
                responseMessage += "Id Should be a positive integer.\n";
            if (book.Price < 0)
                responseMessage += "Price Should be a positive integer.\n";
            if (string.IsNullOrEmpty(book.Name) || !IsValidString(book.Name))
                responseMessage += "Name is required and should contain only alphabets.\n";
            if (string.IsNullOrEmpty(book.Category) || !IsValidString(book.Category))
                responseMessage += "Category is required and should contain only alphabets.\n";
            if (string.IsNullOrEmpty(book.Author) || !IsValidString(book.Author))
                responseMessage += "Author is required and should contain only alphabets.\n";

            return responseMessage;
        }

        private static bool IsValidString(string input)
        {
            return Regex.IsMatch(input, @"(?i)^[a-z.,\s]+$");
        }
    }
}