/*Create a class Student with the following members:
- A string field Name.
- A int field Age.
- A string field Grade.
Define a parameterized constructor that accepts values for Name, Age, and Grade, and
 assigns them to the corresponding fields. Write a program that creates an instance of 
 the Student class by passing arguments to the constructor and displays the student's details.
*/
using System;
    namespace  Test{
        public class Student{
            //fields
            public string Name{get;set;}
            public int Age{get;set;}
            public string Grade{get;set;}
        
        public Student(string name,int age,string grade){
          Name=name;
          Age=age;
          Grade=grade;
        }
        public void DisplayAll(){
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Grade: "+Grade);
        }
        }
        public class Myclass{
            public static void Main(){
                Student c=new Student("Kamal",22,"A+");
                Console.WriteLine("Students Details:");
                c.DisplayAll();
            }
        }
    }
    
        
    
