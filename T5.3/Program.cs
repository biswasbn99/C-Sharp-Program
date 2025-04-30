/*You are developing a transportation management system that handles different types of vehicles
such as cars, bikes, and trucks. Each vehicle must implement the following behaviors:startEngine()
– All vehicles must have a way to start their engine.stopEngine() – All vehicles must have a way
to stop their engine.calculateFuelEfficiency() – Each vehicle calculates fuel efficiency
differently.Trucks must have an additional functionality, loadCargo(), to load goods.Write a
program to design the system using abstract classes, interfaces, or both, ensuring it adheres to the
principles of good object-oriented design. Implement at least two specific vehicle types (e.g., Car
and Truck). */

/*You are developing a transportation management system that handles different types of vehicles
such as cars, bikes, and trucks. Each vehicle must implement the following behaviors:startEngine()
– All vehicles must have a way to start their engine.stopEngine() – All vehicles must have a way
to stop their engine.calculateFuelEfficiency() – Each vehicle calculates fuel efficiency
differently.Trucks must have an additional functionality, loadCargo(), to load goods.Write a
program to design the system using abstract classes, interfaces, or both, ensuring it adheres to the
principles of good object-oriented design. Implement at least two specific vehicle types (e.g., Car
and Truck). */

using System;

namespace TransportationManagementSystem
{
    public interface IVehicle
    {
        void StartEngine();
        void StopEngine();
        void CalculateFuelEfficiency();
    }

    public interface ITruckloadcargo
    {
       public void LoadCargo();
    }

    public abstract class Vehicle : IVehicle
    {
        public double DistanceTravelled { get; set; }
        public double FuelUsed { get; set; }

        public Vehicle(double distanceTravelled, double fuelUsed)
        {
            DistanceTravelled = distanceTravelled;
            FuelUsed = fuelUsed;
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void CalculateFuelEfficiency();
    }

    public class Car : Vehicle
    {
        public Car(double distanceTravelled, double fuelUsed) : base(distanceTravelled, fuelUsed) {}

        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }

        public override void CalculateFuelEfficiency()
        {
            double efficiency = DistanceTravelled / FuelUsed;
            Console.WriteLine("Car fuel efficiency: " + efficiency + " km/L");
        }
    }

    public class Bike : Vehicle
    {
        public Bike(double distanceTravelled, double fuelUsed) : base(distanceTravelled, fuelUsed) {}

        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }

        public override void CalculateFuelEfficiency()
        {
            double efficiency = DistanceTravelled / FuelUsed;
            Console.WriteLine("Bike fuel efficiency: " + efficiency + " km/L");
        }
    }

    public class Truck : Vehicle, ITruckloadcargo
    {
        public Truck(double distanceTravelled, double fuelUsed) : base(distanceTravelled, fuelUsed) {}

        public override void StartEngine()
        {
            Console.WriteLine("Truck engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Truck engine stopped.");
        }

        public override void CalculateFuelEfficiency()
        {
            double efficiency = DistanceTravelled / FuelUsed;
            Console.WriteLine("Truck fuel efficiency: " + efficiency + " km/L");
        }

        public void LoadCargo()
        {
            Console.WriteLine("Truck is loading cargo.");
        }
    }

    public class MyClass
    {
        public static void Main()
        {
            Car car = new Car(50, 2);
            car.StartEngine();
            car.CalculateFuelEfficiency();
            car.StopEngine();

            Console.WriteLine();

            Bike bike = new Bike(100, 2);
            bike.StartEngine();
            bike.CalculateFuelEfficiency();
            bike.StopEngine();

            Console.WriteLine();

            Truck truck = new Truck(20, 4);
            truck.StartEngine();
            truck.CalculateFuelEfficiency();
            truck.LoadCargo();
            truck.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Enter distance travelled by another truck:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fuel used by the truck:");
            double m = Convert.ToDouble(Console.ReadLine());

            Truck anotherTruck = new Truck(n, m);
            anotherTruck.StartEngine();
            anotherTruck.CalculateFuelEfficiency();
            anotherTruck.LoadCargo();
            anotherTruck.StopEngine();

            Console.WriteLine("Program Completed.");
        }
    }
}
