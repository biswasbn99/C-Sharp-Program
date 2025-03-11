/*Create a list of objects representing Books with the following properties:
 BookID (int),Title (string), Author (string), Price (decimal). Perform the following tasks
  using LINQ:
Filters to find books authored by "John Doe" with a price between 200 and 800
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookFilterApp
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public Book(int bookID, string title, string author, decimal price)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Price = price;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Creating a list of books
            List<Book> books = new List<Book>
            {
                new Book(1, "C# Basics", "John Doe", 500),
                new Book(2, "LINQ in Action", "Jane Smith", 700),
                new Book(3, "Advanced C#", "John Doe", 250),
                new Book(4, "ASP.NET Core", "John Doe", 900),
                new Book(5, "Java Essentials", "Alice Brown", 400)
            };

            // LINQ Query to filter books by "John Doe" with a price between 200 and 800
            var filteredBooks = books.Where(b => b.Author == "John Doe" && b.Price >= 200 && b.Price <= 800);

            // Display the filtered books
            Console.WriteLine("Books by John Doe with price between 200 and 800:");
            foreach (var book in filteredBooks)
            {
                 Console.WriteLine("BookID: " +book.BookID+", Title: " +book.Title+", Price: " +book.Price);
            }
        }
    }
}
