/*Different Animal behaves differently. The communication is also different for each of
them. We know Dog will bark, similarly, cow will moo, cat will meow. Though all of
them are animals they will behave differently. */
using System;
namespace Test
{
    public abstract class Animal
    {
        public abstract void AnimalBehavior();
    }

    public class Dog :Animal
    {
        public override void AnimalBehavior()
        {
            Console.WriteLine("The Dog is barking !!!");
        }
    }
    public class Cow :Animal{
        public override void AnimalBehavior()
         {
        Console.WriteLine("The cow is mooing !!1");
    }
    }

   
    public class Cat :Animal
    {
        public override void AnimalBehavior()
    {
        Console.WriteLine("The Cat is meowing");
    }
    }
    

    public class MyClass
    {
        public static void Main()
        {
            Dog dog=new Dog();
            dog.AnimalBehavior();
            Cow cow=new Cow();
            cow.AnimalBehavior();
            Cat cat=new Cat();
            cat.AnimalBehavior();
              Console.WriteLine("\n \n \n");
            //Alternative
            Animal dog1= new Dog();
            dog1.AnimalBehavior();
            Animal cow1= new Cow();
            cow1.AnimalBehavior();
            Animal cat1=new Cat();
            cat1.AnimalBehavior();

            
        }
    }
}