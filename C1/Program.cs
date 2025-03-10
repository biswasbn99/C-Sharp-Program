/* 
1. Create a class Car with the following members:  
   - A string field Brand.  
   - A string field Model.  

   Define a default constructor that initializes these fields with default values:  
   -"Unknown Brand" for Brand.  
   -"Unknown Model" for Model.  

2. Implement a method ShowDetails() that prints the values of Brand and Model.  

3. Write a program that creates an instance of the Car class using the default constructor
 and calls the ShowDetails() method to display the values of the fields. */
 using System;
 namespace Test{
    public class Car{
        //Fields
        public string Model;
        public string Brand;
        //Default Constructor
        public Car(){
           
           Model="Unknown Model";
           Brand="Unknown Car";
        }
        //display
        public void ShowDetails(){
            Console.WriteLine("Model: " +Model);
            Console.WriteLine("Brand: "+Brand);
        }
    }
public class Myclass{
    public static void Main(){
        Car c=new Car();
        c.ShowDetails();
    }
}
 }