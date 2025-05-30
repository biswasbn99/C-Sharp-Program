
/*write a C# program with a class called Animal which will have some member 
method as walk and eat. 
a) Create a child class of Animal called Dog with the property nooflegs and bark 
b) Create a child class of Animal  called Bird with the property noofwings and fly 
c) Create a child class of Bird called Dove with the property color . */
using System;
namespace Test
{
    public class Animal
    {
        public void Walk()
        {
            Console.WriteLine("Animal is Walking");
        }
        public void Eat()
        {
            Console.WriteLine("Animal is Eatting");
        }
    }
    public class Dog : Animal
    {
        public string NoOfLeg { get; set; }
        public string Bark { get; set; }
        public Dog(string noofleg, string bark)
        {
            NoOfLeg = noofleg;
            Bark = bark;
        }
        public void LegInfo()
        {
            Console.WriteLine(NoOfLeg);
        }
        public void BarkInfo()
        {Console.WriteLine(Bark);
        }

    }
    public class Bird : Animal
    {
        public string NoOfWings { get;set; }
        public string Fly {  get; set; }

        public Bird(string noOfWings, string fly)
        {
            NoOfWings = noOfWings;
            Fly = fly;
        }
        public void Winginfo()
        {
            Console.WriteLine(NoOfWings);
        }
        public void FlyInfo()
        {
            Console.WriteLine(Fly);
        }
    }
    public class Dove:Bird
    {
        public string Color {  get; set; }
        public Dove(string noOfWings,string fly,string color):base(noOfWings,fly) 

        {
            Color = color;
        }
        public void ColorInfo()
        {
            Console.WriteLine(Color);
        }
    }
    public class Myclss
    {
        public static void Main()
        {
            Animal animal = new Animal();
            animal.Walk();
            animal.Eat();

            Dog dog=new Dog("Dog has 4 legs","Dog is barking");
            dog.LegInfo();
            dog.BarkInfo();

            Bird bird = new Bird("Bird has 2 wings","Bird is flying");
            bird.Winginfo();
            bird.FlyInfo();

            Dove dove = new Dove("Dove has 2 wings","dove is Fliying","Dove is very beatiful");
            dove.ColorInfo();


        }
    }
}
