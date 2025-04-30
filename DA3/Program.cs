/*Write a C# program to demonstrate the concept of aggregation by creating a Department
class and an Employee class where multiple employees can be associated with a single
 department.*/
 using System;
 namespace Test
 {
    public class Department
    {
        public string DepartmentName{get;set;}
        public Department(string deptName)
        {
        DepartmentName=deptName;
        }
    }
    public class Employee
    {
       public string EmployeeName{get;set;}
      public  Department Dept{get;set;}
       public Employee(string empName,Department dept )
       {
        EmployeeName=empName;
        Dept=dept;
       }
       public void displays()
       {
        Console.WriteLine("Employee Name: "+EmployeeName+"Department Name: "+Dept.DepartmentName);
       }
    }
    public class Myclass{
        public static void Main()
        {
            Department department=new Department("IT");
            Employee employee=new Employee("Kamal",department);
            Employee employee1=new Employee("Jamal",department);
            employee.displays();
            employee1.displays();

        }
    }
    
 }
 

