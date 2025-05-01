/*Create two classes, Department and Employee. 
 The Employee class should have properties: Id, Name, and Position. 
 The Department class should have a List<Employee> property representing the employees 
working in that department. 
 Write a method in the Department class that displays all employees in the department.*/
using System;
using System.Collections.Generic;
namespace Test
{
    public class Employee
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Position{get;set;}
        public Employee(int id,string name,string position)
        {
            Id=id;
            Name=name;
            Position=position;
        }
    }
    public class Department
    {
        public List<Employee> Employees{get;set;}
        public Department()
        {
            Employees=new List<Employee>();
        }
        public void DisplayEmployeeMessage()
        {
            Console.WriteLine("All Employees in the department : ");
            foreach(var emp in Employees)
            {
Console.WriteLine("Employee Name : "+emp.Name+ "   Employee ID : "+emp.Id+ "    Employee Position : "+emp.Position);
            }
        }
    }
   public class Myclass
   {
public static void Main()
{
    Department department=new Department();
    department.Employees.Add(new Employee(223,"Kamal", "IT Eng."));
    department.Employees.Add(new Employee(221,"Alex","IT Manager"));
    department.Employees.Add(new Employee(220, "Milton","Head of IT Dept."));
    department.DisplayEmployeeMessage();
}
   }
    
    
}