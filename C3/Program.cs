/*Create a class Car with the following members:
- A string field Model.
- A string field Brand.
Define a copy constructor that creates a new instance of the Car class by copying the
values from another Car object. Write a program that creates a Car object using the 
parameterized constructor, then creates a second Car object using the copy constructor,
and displays the details of both cars. */
using System;
namespace Test{
    public class Car{
        //Fields
        public string Model{get;set;}
        public string Brand{get;set;}
        //Parameterized Constructor
        public Car(string model,string brand){
            Model=model;
            Brand=brand;
        }
        //Copy Constructor
        public Car(Car c){
            Model=c.Model;
            Brand=c.Brand;
        }
        public void ShowDetails(){
            Console.WriteLine("Model :"+Model+", Brand :"+Brand);
        }
    }
    public class Myclass{
        public static void Main(){
            Car c1=new Car("Corolla","Toyota");
    Car c2=new Car(c1);

    Console.WriteLine("Display orginal car details: ");
    c1.ShowDetails();
    Console.WriteLine("Display Copied car details: ");
    c2.ShowDetails();
        }
    }
}