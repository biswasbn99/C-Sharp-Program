/* Hybrid Inheritance:

Create a class Machine with a method Start(). Define an interface IEngine with a
 method RunEngine(). Create a class Car that inherits from Machine and also implements 
 the IEngine interface. The Car class should provide implementations for both the Start()
 method from Machine and the RunEngine() method from IEngine. Write a program to 
 demonstrate hybrid inheritance by creating a Car object and calling both methods.*/
 using System;
 namespace Test
 {
    public class Machine{
        public void Start()
        {
            Console.WriteLine("The Machine is starting !!");
        }
    }

    public interface IEngine
    {
        public void RunEngine();

        
    }
    public class Car :Machine,IEngine
    {
      public void RunEngine()
      {
        Console.WriteLine("The Engine is running !!");
      }
    }

    public class Myclass{
        public static void Main()
        {
            Car car=new Car();
            car.Start();
            car.RunEngine();
        }
    }
 }