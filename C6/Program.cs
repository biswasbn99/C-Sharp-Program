/*Create a class Book with the following members:
- A string field Title.
- A string field Author.
- A double field Price.
Define a copy constructor that creates a new instance of the Book class by copying the 
values from another Book object. Write a program that creates a Book object using the
parameterized constructor, then creates a second `Book` object using the copy constructor,
and displays the details of both books.
*/
using System;
namespace Test{
    public class Book{
        //Fields
        public string Title{get;set;}
        public string Author{get;set;}
        public double Price{get;set;}
        //Parameterized Constructor
        public Book(string title,string author,double price){
            Title=title;
            Author=author;
            Price=price;
        }
        //copy Constructor
        public Book(Book c){
            Title=c.Title;
            Author=c.Author;
            Price=c.Price;
        }
        public void DisplayAll(){
            Console.WriteLine("Title : "+Title);
             Console.WriteLine("Author : "+Author);
              Console.WriteLine("Price : "+Price);
        }

    }
    public class Myclass{
        public static void Main(){
            Book c1=new Book("The science","Hanson",278.56);
            Book c2=new Book(c1);
         
            Console.WriteLine("Original Books details:");
            c1.DisplayAll();
               Console.WriteLine();
            Console.WriteLine("Copied Books details: ");
            c2.DisplayAll();
        }
    }
}