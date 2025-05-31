/*Create a list of employees with the following properties:
EmployeeID (int)
Name (string)
Department (string)
Salary (decimal)
Task:
Use LINQ to filter employees from the &quot;IT&quot; department who have a salary between 50,000
and 100,000. */
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Creating a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "Alice", Department = "IT", Salary = 75000 },
            new Employee { EmployeeID = 2, Name = "Bob", Department = "HR", Salary = 60000 },
            new Employee { EmployeeID = 3, Name = "Charlie", Department = "IT", Salary = 45000 },
            new Employee { EmployeeID = 4, Name = "David", Department = "Finance", Salary = 90000 },
            new Employee { EmployeeID = 5, Name = "Eve", Department = "IT", Salary = 95000 }
        };

        // LINQ query to filter IT department employees with salary between 50,000 and 100,000
        var filteredEmployees = employees
            .Where(e => e.Department == "IT" && e.Salary >= 50000 && e.Salary <= 100000)
            .ToList();

        // Display the filtered employees
        foreach (var emp in filteredEmployees)
        {
            Console.WriteLine("ID: "+emp.EmployeeID+", Name: "+emp.Name+", Department: "+emp.Department+", Salary: "+emp.Salary);
        }
    }
}
