/*Create a list of objects representing Books with the following properties:
BookID (int),Title (string), Author (string), Price (decimal). Perform the following tasks
using LINQ:
Filters to find books authored by &quot;John Doe&quot; with a price between 200 and 800 */
using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Creating a list of books
        List<Book> books = new List<Book>
        {
            new Book { BookID = 1, Title = "C# Basics", Author = "John Doe", Price = 500 },
            new Book { BookID = 2, Title = "Advanced C#", Author = "Jane Smith", Price = 750 },
            new Book { BookID = 3, Title = "LINQ in Action", Author = "John Doe", Price = 250 },
            new Book { BookID = 4, Title = "Intro to Programming", Author = "John Doe", Price = 900 },
            new Book { BookID = 5, Title = "Data Structures", Author = "Alice Johnson", Price = 300 }
        };

        // LINQ query to filter books by John Doe with price between 200 and 800
        var filteredBooks = books
            .Where(book => book.Author == "John Doe" && book.Price >= 200 && book.Price <= 800)
            .ToList();

        // Display the filtered books
        foreach (var book in filteredBooks)
        {
            Console.WriteLine("ID: "+book.BookID+", Title: "+book.Title+", Author: "+book.Author+", Price: "+book.Price);
        }
    }
}
