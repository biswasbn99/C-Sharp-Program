/*Write a C# Program with a class called Inherit which should have a String type 
variable named str and a member method with the name  inheritmethod.  
a) Create a child class of Inherit with the name InheritChild and access 
the str from Inherit class. and it will have its own method called inheritchildmethod 
b) Create a child class of InheritChild with the name Child and from this class 
access all the property from it's parents. */
using System;
namespace Test
{
    public class Inherit
    {
        public string Str { get; set; }
        public Inherit(string str)
        {
            Str = str;
        }
        public void Display()
        {
            Console.WriteLine(Str);
        }
        public void Inheritmethod()
        {
            Console.WriteLine("It is an Inherit class");
        }

    }
    public class InheritChild : Inherit
    {
        public InheritChild(string str) : base(str) { }


        public void InheritChildemethod()
        {
            Console.WriteLine("It is a Inherit child class");
        }
    }
    public class Child : InheritChild
    {
       public Child(string str) : base(str)
        {
        }

        public void Inheritchild()
        {
            Console.WriteLine("It is a child class ");
        }


    }
    public class Myclass
    {
        public static void Main()
        {
           
            Child child = new Child("Hello");
            child.Display();
            child.Inheritmethod();
            child.InheritChildemethod();
            child.Inheritchild();


        }

    }
}