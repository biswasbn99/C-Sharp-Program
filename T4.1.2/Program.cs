/*Write a C# program on the given scenario :
ABC Company has two types of employees Manager and Programmer. Based on their
role they have separate job responsibilities. The company calculate the salary of their
employees. But the calculation formula for Employee is different for different types of
role. Take input from user*/
using System;

namespace Test
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double BaseSalary { get; set; }

        public abstract void Role();
        public abstract double CalculateSalary();
    }

    public class Manager : Employee
    {
        public double BonusPercentage { get; set; }

        public override void Role()
        {
            Console.WriteLine(Name + " Responsibilities: ");
            Console.WriteLine("Team Management & Supervision \nProject manage & Completion \nPerformance Reviews");
        }

        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * (BonusPercentage / 100));
        }
    }

    public class Programmer : Employee
    {
        public double OverTime { get; set; }
        public double HourlyRate { get; set; }

        public override void Role()
        {
            Console.WriteLine(Name + " Responsibilities: ");
            Console.WriteLine("Writing code and developing Software \nTesting Software \nMaintaining the software");
        }

        public override double CalculateSalary()
        {
            return BaseSalary + (OverTime * HourlyRate);
        }
    }

    public class MyClass
    {
        public static void Main()
        {
            // Manager input
            Manager manager = new Manager();
            Console.WriteLine("Enter Manager Name:");
            manager.Name = Console.ReadLine();

            Console.WriteLine("Enter Manager ID:");
            manager.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Base Salary for Manager:");
            manager.BaseSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Bonus Percentage for Manager:");
            manager.BonusPercentage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=====Manager Details====");
            Console.WriteLine("Name: " + manager.Name);
            Console.WriteLine("Manager ID: " + manager.ID);
            manager.Role();
            Console.WriteLine(manager.Name + "'s Salary: " + manager.CalculateSalary());

            Console.WriteLine("\n\n");

            // Programmer input
            Programmer programmer = new Programmer();
            Console.WriteLine("Enter Programmer Name:");
            programmer.Name = Console.ReadLine();

            Console.WriteLine("Enter Programmer ID:");
            programmer.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Base Salary for Programmer:");
            programmer.BaseSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Overtime Hours:");
            programmer.OverTime = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Hourly Rate:");
            programmer.HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=====Programmer Details====");
            Console.WriteLine("Name: " + programmer.Name);
            Console.WriteLine("Programmer ID: " + programmer.ID);
            programmer.Role();
            Console.WriteLine(programmer.Name + "'s Salary: " + programmer.CalculateSalary());
        }
    }
}
