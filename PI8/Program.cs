/*Create a list of employees with the following properties:
EmployeeID (int)
Name (string)
Department (string)
Salary (decimal)
Task:
Use LINQ to filter employees from the "IT" department who have a salary between
 50,000 and 100,000.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeFilterApp
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(int employeeID, string name, string department, decimal salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Creating a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Alice", "IT", 75000),
                new Employee(2, "Bob", "HR", 60000),
                new Employee(3, "Charlie", "IT", 90000),
                new Employee(4, "David", "Finance", 55000),
                new Employee(5, "Eve", "IT", 120000)
            };

            // LINQ Query to filter employees from IT department with salary between 50,000 and 100,000
            var filteredEmployees = employees.Where(e => e.Department == "IT" && e.Salary >= 50000 && e.Salary <= 100000);

            // Display the filtered employees
            Console.WriteLine("Employees from IT department with salary between 50,000 and 100,000:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine("EmployeeID: " +emp.EmployeeID +", Name:"+ emp.Name+", Salary: "+emp.Salary);
            }
        }
    }
}
