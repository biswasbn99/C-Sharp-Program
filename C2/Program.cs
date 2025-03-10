/* Create a class Car with the following members:  
   - A string field Brand.  
   - A string field Model.  
Define a parameterized constructor that accepts two parameters:  
   - A string parameter for Model.  
   - A string parameter for Brand.  
 The constructor should initialize the corresponding fields using these parameters.  
Implement a method ShowDetails() that prints the values of Brand and Model.  
In the Main method, create an instance of the Car class using the parameterized constructor
 with the values Corolla for Model and Toyota for Brand.Call the ShowDetails() method to
  display the car details.  
 */
 using System;
 namespace Test{
    public class Car{
        //Fields
        public string Model;
        public string Brand;
        //Parameterized Constructor
        public Car(string model,string brand){
            Model=model;
            Brand=brand;
        }
        //Display
        public void ShowDetails(){
            Console.WriteLine("Model: "+Model);
            Console.WriteLine("Brand: "+Brand);
        }
    }
    public class Myclass{
        public static void Main(){
            Car c=new Car("Corolla","Toyota");
            c.ShowDetails();

        }
    }
 }