/*Multiple Inheritance using Interfaces:

Define two interfaces: IAthlete and IMusician. IAthlete should have a method
PlaySport() and IMusician should have a method PlayInstrument(). Then create a class
Person that implements both interfaces. Write a program that demonstrates multiple inheritance
using interfaces by creating a Person object that can play a sport and an instrument. */
using System;
namespace Test{
    public interface IAthlete
    {
        public void PlaySport();
    }
    public interface IMusician
    {
        public void PlayInstrument();
    }
    public class Person :IAthlete,IMusician
    {
        public string Name{get;set;}
        public Person(string name)
        {
            Name= name;
        }
        public void PlaySport(){
             Console.WriteLine(Name+" is playing a sport ");
        }
        public void PlayInstrument()
        {
            Console.WriteLine(Name + " is playing an instrument");
        }
           
        
    }

    public class Myclass{
        public static void Main()
        {
            Person person =new Person("Alex");
            person.PlaySport();
            person.PlayInstrument();
        }
    }
}