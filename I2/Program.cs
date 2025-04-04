/*Create three classes: Animal, Mammal, and Dog. The Animal class should have a method 
Eat(). The Mammal class should inherit from Animal and have an additional method Walk().
The Dog class should inherit from Mammal and have a method Bark(). Write a program to
demonstrate multilevel inheritance by creating a Dog object and calling all the inherited
methods.*/
using System;
namespace Test{

    public class Animal{
        public void Eat(){
            Console.WriteLine("Animal is eating.");
        }
    }
    public class Mammal : Animal
    {
public void Walk(){
    Console.WriteLine("Mammal is walking");
}
    }

    public class Dog :Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking. ");
        }
    }
    public class Myclass {
        public static void Main(){
            Dog dog= new Dog();
            dog.Eat();
            dog.Walk();
            dog.Bark();
        }
    }
}