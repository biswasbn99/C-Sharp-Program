/*Basic Idea of Properties */
using System;
namespace Test{
    class Person{
        private string name;
        private int age;
        public string Name{    //Variable must be capital Letter
            get{return name;}
            set{name=value;}
        }
        public int Age{ //variable must be capital letter
            get{return age;}
            set{age=value;}

        }
        public void DisplayAll(){
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
        }
    }
    public class Myclass{
        public static void Main(){
            Person p=new Person();
            p.Name="Kamal";
            p.Age=27;
            p.DisplayAll();
        }
    }

}