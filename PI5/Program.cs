/*Design a class Employee that has three properties: FirstName, LastName, and
 a read-only property FullName. The FullName property should return the concatenation 
 of FirstName and LastName. Instantiate the class and display the full name of an employee.*/
 using System;

namespace EmployeeApp
{
    class Employee
    {
        public string FirstName { get; set; } // Property for First Name
        public string LastName { get; set; }  // Property for Last Name

        // Read-only FullName property that concatenates FirstName and LastName
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        // Constructor to initialize FirstName and LastName
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        public static void Main()
        {
            // Creating an instance of Employee
            Employee emp = new Employee("Hanson", "Alis");

            // Displaying the full name
            Console.WriteLine("Employee Full Name: " + emp.FullName);
        }
    }
}
