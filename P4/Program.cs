/*Create two classes: Animal and Dog. The Animal class should have a virtual method 
MakeSound() that prints "Animal sound". In the Dog class, override the MakeSound()
method to print "Bark". Write a program that demonstrates **run-time polymorphism** by 
creating a base class reference (Animal) and pointing it to a derived class object (Dog).
Call the MakeSound() method using the base class reference. */
using System;
namespace Test
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    public class Dog :Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Myclass
    {
        public static void Main()
        {
           Animal animal=new Animal();
           Animal dog=new Dog();
           animal.MakeSound();
           dog.MakeSound();

         Console.WriteLine("\n \n \n");
           //Alternative
           Animal animal1=new Animal();
           Dog dog1=new Dog();
           animal1.MakeSound();
           dog1.MakeSound();
        }
    }

}