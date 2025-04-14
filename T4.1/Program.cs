/*Write a C# program on the given scenario :
ABC Company has two types of employees Manager and Programmer. Based on their
role they have separate job responsibilities. The company calculate the salary of their
employees. But the calculation formula for Employee is different for different types of
role. */

using System;

namespace Test
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, int id, double baseSalary)
        {
            Name = name;
            ID = id;
            BaseSalary = baseSalary;
        }

        public abstract void Role();
        public abstract double CalculateSalary();
    }

    public class Manager : Employee
    {
        public double BonusPercentage { get; set; }

        public Manager(string name, int id, double baseSalary, double bonusPercentage)
            : base(name, id, baseSalary)
        {
            BonusPercentage = bonusPercentage;
        }

        public override void Role()
        {
            Console.WriteLine(Name + " Responsibilities: ");
            Console.WriteLine("Team Management & Supervision \nProject manage & Completion \nPerformance Reviews");
        }

        public override double CalculateSalary()
        {
            // Manager Salary = BaseSalary + (BaseSalary * BonusPercentage)
            return BaseSalary + (BaseSalary * (BonusPercentage / 100));
        }
    }

    public class Programmer : Employee
    {
        public double OverTime { get; set; }
        public double HourlyRate { get; set; }

        public Programmer(string name, int id, double baseSalary, double overtime, double hourlyRate)
            : base(name, id, baseSalary)
        {
            OverTime = overtime;
            HourlyRate = hourlyRate;
        }

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
            Manager manager = new Manager("Alex", 23456, 35000, 10);

            Console.WriteLine("=====Manager Details====");
            Console.WriteLine("Name: " + manager.Name);
            Console.WriteLine("Manager ID: " + manager.ID);
            manager.Role();
            Console.WriteLine(manager.Name + "'s Salary: " + manager.CalculateSalary());

            Console.WriteLine("\n\n\n\n");

            Programmer programmer = new Programmer("Milton", 3035, 28800, 30, 250);
            Console.WriteLine("=====Programmer Details====");
            Console.WriteLine("Name: " + programmer.Name);
            Console.WriteLine("Programmer ID: " + programmer.ID);
            programmer.Role();
            Console.WriteLine(programmer.Name + "'s Salary: " + programmer.CalculateSalary());
        }
    }
}