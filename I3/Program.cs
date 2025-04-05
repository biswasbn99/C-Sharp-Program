/* Hierarchical Inheritance:

 Create a base class Vehicle with a property Speed and a method ShowSpeed(). 
Then create two derived classes, Car and Bike, which inherit from Vehicle. Both Car and 
Bike should have their own method ShowType() that prints whether the vehicle is a car or a 
bike. Demonstrate hierarchical inheritance by creating objects of both Car and Bike.*/
using System;
namespace Test{
    public class Vehicle{
        public int Speed{get;set;}
        public Vehicle(int speed)
        {
            Speed=speed;
        }
        public void ShowSpeed()
        {
            Console.WriteLine("Speed :"+Speed);
        }
    }
    public class Car :Vehicle
    {
        public Car(int speed) :base(speed)
        {

        }
        public void ShowType(){
Console.WriteLine("This ia a Car. ");
        }
    }

    public class Bike :Vehicle{
        public Bike(int speed) :base(speed)
        {

        }
        public void ShowType()
        {
            Console.WriteLine("This ia Bike .");
        }
    }
    public class Myclass{
        public static void Main(){
            Car car=new Car(130);
            car.ShowSpeed();
            car.ShowType();

            Bike bike=new Bike(120);
            bike.ShowSpeed();
            bike.ShowType();


        }
    }
    }