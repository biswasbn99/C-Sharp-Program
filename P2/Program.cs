/* Write a C# program that demonstrates the use of method overriding with a base class Animal
 and two derived classes Dog and Cat. The Animal class should have a virtual Speak method that
  can be overridden in both the Dog and Cat classes*/
  using System;
  namespace Test
  {
    public class Animal
    {
        public virtual void Speak(){
            Console.WriteLine("The animal is making a sound ");
        }
    
  }
  public class Dog :Animal
  {
        public override void Speak()
        {
            Console.WriteLine("The Dog is Barking");
        }
  }
  public class Cat :Animal
  {
        public override void Speak()
        {
            Console.WriteLine("The Cat is Meowing");
        }
  }
  public class Myclass
  {
    public static void Main(){
        Animal animal= new Animal();
        Animal dog=new Dog();
        Animal cat =new Cat();
        animal.Speak();
        dog.Speak();
        cat.Speak();
    }
  }
  }