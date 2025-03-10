/*Create a class Car with the following members:
- A string field Brand.
- A string field Model.
- A int field Year.
Define a default constructor that initializes these fields with default values:
 Unknown for Brand, Unknown for Model, and 0 for Year. Write a program that
  creates an instance of the Car class using the default constructor and displays
   the values of the fields.
*/
using System;
namespace Test{
    public class Car{
        //Field
        public string Brand{get;set;}
        public string Model{get;set;}
        public int Year{get;set;}
        //Defaul Constructor
        public Car(){
            Brand="Unknown Brand";
            Model="Unknown Model";
            Year=0;
        }
        //display
        public void DisplayAll(){
            Console.WriteLine("Brand: "+Brand);
            Console.WriteLine("Model: "+Model);
            Console.WriteLine("Year : "+Year);
        }
    }
    public class Myclass{
        public static void Main(){
            Car c=new Car();
            c.DisplayAll();
        }
    }
}