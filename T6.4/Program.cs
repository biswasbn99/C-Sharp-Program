/*Imagine you're developing a for a local library. In this system, you need to model various 
entities such as Library, Book, and Author. 
 Each book has the following properties: Title, ISBN, Genre, and Price. 
 A book is associated with one or more Authors 
  
 Each author has the properties: Name, Bio, and DateOfBirth. 
  
 The library has a collection of books. Each book is part of the library's collection. 
 The library also needs to have a method to display all the books along with their authors. 
 Additionally, the library should have a method to calculate the total cost of all books in its 
collection. 
 Create a Library that has multiple Book objects. 
 Each Book can have one or more Author objects associated with it. 
 Implement a method in the Library class to display all books along with their authors. 
 Implement a method in the Library class to calculate the total price of all the books in the 
library. */

using System;
using System.Collections.Generic;
namespace Test
{
    public class Book{
        public string Title{get;set;}
        public string ISBN{get;set;}
        public string Genre{get;set;}
        public double Price{get;set;}
        public List<Author> Authors{get;set;}
        public Book(string title,string isbn, string genre,double price)
        {
            Title=title;
            ISBN=isbn;
            Genre=genre;
            Price=price;
            Authors=new List<Author>();

        }
    }
    public class Author 
    {
        public string Name{get;set;}
        public string Bio{get;set;}
        public DateTime DateOfBirth{get;set;}
        public Author(string name,string bio ,DateTime dateOfBirth)
        {
            Name=name;
            Bio=bio;
            DateOfBirth=dateOfBirth;
        }
    }
    public class Library
    {
        public List<Book> Books{get;set;}
        public Library()
        {
            Books=new List<Book>();
        }
       public void displays(){
        Console.WriteLine("All Books in library :  ");
        foreach(var books in Books)
        {
            Console.WriteLine("Title : "+books.Title +" ISBN : "+books.ISBN+ " Genre : "+books.Genre+ " Price: "+books.Price+" Tk.");
       Console.WriteLine("Authors: ");
        foreach(var author in books.Authors)
        {
            Console.WriteLine("Name: "+author.Name +" Bio : "+author.Bio+ " Date Of Birth : "+author.DateOfBirth.ToShortDateString());
        }
       Console.WriteLine("\n \n \n");
        }
        
       }
       public double CalculateTotalPrice(){
        
        double total=0;
        foreach(var book in Books)
        {
          total+=book.Price;
          
        }
        return total;
       }
    }
    public class Myclass
    
    {
        public static void Main()
        {
            Book book1=new Book("Assembly","23456789654","Education", 250);
            Book book2=new Book("C#","3637373474","Education",400);
            Author author1=new Author("Alam", "He is a Professor .",new DateTime(1981,6,1));
            Author author2=new Author("Alex","He is a Professor and researcher.",new DateTime(1989,12,9));
           
           book1.Authors.Add(author1);
           book1.Authors.Add(author2);
           
           book2.Authors.Add(author2);
           Library library=new Library();
           library.Books.Add(book1);
           library.Books.Add(book2);
           library.displays();
          Console.WriteLine("Total Price : "+ library.CalculateTotalPrice()+ " Tk");
        }
    }
}