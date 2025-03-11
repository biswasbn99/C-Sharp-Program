/* Employee Salary Calculation Using Constructor and Method Problem Statement: 
Create a class Employee with properties: 
EmployeeID (int) Name (string) Salary (double) 
Define: A constructor to initialize these values. A method CalculateBonus(double percentage)
that calculates and returns the bonus*/
using System;

namespace EmployeeBonusApp
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        // Constructor to initialize values
        public Employee(int employeeID, string name, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Salary = salary;
        }

        // Method to calculate bonus based on percentage
        public double CalculateBonus(double percentage)
        {
            return Salary * (percentage / 100);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Creating an employee object
            Employee emp = new Employee(1, "Alice", 60000);

            // Calculating bonus
            double bonus = emp.CalculateBonus(10); // 10% bonus

            // Displaying results
            Console.WriteLine("Employee ID: "+emp.EmployeeID);
            Console.WriteLine("Name: "+emp.Name);
            Console.WriteLine("Salary: "+emp.Salary);
            Console.WriteLine("Bonus (10%): "+ bonus);
        }
    }
}
