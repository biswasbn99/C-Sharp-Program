/*Define an interface `IVehicle` with two methods: `Start()` and `Stop()`. Create
two classes, `Car` and `Bike`, that implement the `IVehicle` interface. The `Car` class
should implement `Start()` to print "Car starting..." and `Stop()` to print "Car
stopping...". The `Bike` class should implement `Start()` to print "Bike starting..." and
`Stop()` to print "Bike stopping...". Write a program that demonstrates interface
implementation by creating instances of both `Car` and `Bike` and calling their
methods. */

using System;
namespace Test

{
    public interface IVehicle
    
    {
        public void Start();
        public void Stop();
    }
    public class Car:IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Starting.....");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopping....");
        }

    }
        public class Bike:IVehicle
        {
            public void Start()
            {
                Console.WriteLine("Bike Starting....");
            }

            public void Stop()
            {
                Console.WriteLine("Bike Stopping.....");
            }
        

    }
public class Myclass
{
    public static void Main()
    {
        IVehicle car =new Car();
        car.Start();
        car.Stop();
        Console.WriteLine("\n");

        IVehicle bike=new Bike();
        bike.Start();
        bike.Stop();

        Console.WriteLine("\n \n \n");
         //altenative
         Car car1 =new Car();
        car1.Start();
        car1.Stop();
        Console.WriteLine("\n");

        Bike bike1=new Bike();
        bike1.Start();
        bike1.Stop();

    }
}

}