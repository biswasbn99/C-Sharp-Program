/*1. Create two classes: Person and Student. The Person class should have the properties
 Name and Age, and a method DisplayInfo() that prints the name and age. The Student 
class should inherit from Person and have an additional property StudentID and method 
 DisplayStudentInfo() that prints the student ID along with the name and age. Demonstrate 
 single inheritance by creating a Student object. */
 using System;
 namespace Test{
    public class Person{
        public string Name{get;set;}
        public int Age{get;set;}
        public Person(string name,int age){
            Name=name;
            Age=age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name :"+Name +", "+"Age :"+Age);
        }
    }
    public class Student : Person
    {
        public int StudentID{get;set;}
        public Student(string name,int age, int studentID) :base(name,age)
        {
            StudentID=studentID;
        }
        public void DisplayStudentInfo(){
            DisplayInfo();
            Console.WriteLine("StudentID :"+StudentID);
        }
    }
    public class Myclass{
        public static void Main(){
            Student student=new Student("Alex", 23, 234056);
            student.DisplayStudentInfo();
        }
    }
 }