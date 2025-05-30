/*Write a C# program to create a vehicle class hierarchy. The base class should be 
Vehicle, with subclasses Truck, Car and Motorcycle. Each subclass should have 
properties such as model, year, and fuel type. Implement methods for calculating 
fuel efficiency, distance travelled, and maximum speed. */
using System;
namespace Test
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }

        public Vehicle(string model, int year, string fueltype)
        {
            Model = model;
            Year = year;
            FuelType = fueltype;
        }
        public abstract void Display();
        public abstract double FuelEfficiency(double distance_travel, double fuelConsumed);
        public abstract double DistaceTravelled(double fuelefficiency, double fuelConsumed);
        public abstract void MaximumSpeed();


    }
    public class Truck : Vehicle
    {
        public Truck(string model, int year, string fueltype) : base(model, year, fueltype) { }
        public override void Display()
        {
            Console.WriteLine("Model :"+Model);
            Console.WriteLine("Year: "+Year );
            Console.WriteLine("Fuel Type :"+FuelType);
        }

        public override double FuelEfficiency(double distance_travel, double fuelConsumed)
        {
            double fueleffi = (distance_travel / fuelConsumed);
            return fueleffi;
        }
        public override double DistaceTravelled(double fuelefficiency, double fuelConsumed)
        {
            double distravel = fuelefficiency * fuelConsumed;
            return distravel;
        }
        public override void MaximumSpeed()
        {
            Console.WriteLine("Max Speed : 80 Km/h");
        }

    }
    public class Car : Vehicle

    {

        public Car(string model, int year, string fueltype) : base(model, year, fueltype) { }
        public override void Display()
        {
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Fuel Type :" + FuelType);
        }
        public override double FuelEfficiency(double distance_travel, double fuelConsumed)
        {
            double fueleffi = (distance_travel / fuelConsumed);
            return fueleffi;
        }
        public override double DistaceTravelled(double fuelefficiency, double fuelConsumed)
        {
            double distravel = fuelefficiency * fuelConsumed;
            return distravel;
        }
        public override void MaximumSpeed()
        {
            Console.WriteLine("Max Speed : 120 Km/h");
        }

    }

    public class MotorCycle : Vehicle
    {
        public MotorCycle(string model, int year, string fueltype) : base(model, year, fueltype) { }
        public override void Display()
        {
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Fuel Type :" + FuelType);
        }
        public override double FuelEfficiency(double distance_travel, double fuelConsumed)
        {
            double fueleffi = (distance_travel / fuelConsumed);
            return fueleffi;
        }
        public override double DistaceTravelled(double fuelefficiency, double fuelConsumed)
        {
            double distravel = fuelefficiency * fuelConsumed;
            return distravel;
        }
        public override void MaximumSpeed()
        {
            Console.WriteLine("Max Speed : 140 Km/h");
        }
    }
    public class Myclass
    {
        public static void Main()
        {
            Truck truck = new Truck("TATA-20185", 2021, "diesel");
            Car car = new Car("Suzuki Alto 800",2022,"Octane");
            MotorCycle motorCycle = new MotorCycle("Hero ALT",2023,"Petrol");
            Console.WriteLine();
            truck.Display();
            Console.WriteLine("Fuel Efficiency :" + truck.FuelEfficiency(100, 2));
            Console.WriteLine("Distanced Travelled :" + truck.DistaceTravelled(50, 2));
            truck.MaximumSpeed();
            Console.WriteLine();
             car.Display();
            Console.WriteLine();
            Console.WriteLine("Fuel Efficiency :" + car.FuelEfficiency(120, 2));
            Console.WriteLine("Distanced Travelled :" + car.DistaceTravelled(60, 2));
            truck.MaximumSpeed();
            Console.WriteLine();
            motorCycle.Display();
           
       
            Console.WriteLine("Fuel Efficiency :" + motorCycle.FuelEfficiency(140, 2));
            Console.WriteLine("Distanced Travelled :" + motorCycle.DistaceTravelled(70, 2));
            truck.MaximumSpeed();


        }
    }

}