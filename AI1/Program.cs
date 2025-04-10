/*Create an abstract class `Shape` with an abstract method `CalculateArea()` and 
a non-abstract method `Display()` that prints "Calculating area...". Then create two 
derived classes, `Circle` and `Rectangle`, that implement the `CalculateArea()` 
method. The `Circle` class should calculate the area of a circle, and the `Rectangle` 
class should calculate the area of a rectangle. Demonstrate the use of the abstract class 
by creating objects of `Circle` and `Rectangle` and calling their methods.  */
using System;
using System.Diagnostics.Contracts;
namespace Test
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public void Display()
        {
            Console.WriteLine("CalCulating Area...");
        }
    }
    public class Circle:Shape
    {
       public double Radius{get;set;}
       public Circle(double radius)
       {
        Radius=radius;
       }
        public override double CalculateArea()
        {
            return Math.PI*Radius*Radius;
        }
    }
    public class Rectangle:Shape
    {
       public double Length{get;set;}
       public double Width{get;set;}
       public Rectangle(double length,double width)
       {
        Length=length;
        Width=width;
       }
        public override double CalculateArea()
        {
            return Length*Width;
        }
    }
    public class Myclass
{
    public static void Main()
    
    {
        Shape circle=new Circle(30);
        circle.Display();
        Console.WriteLine("The area of the circle is "+    circle.CalculateArea().ToString("F2"));

        Shape rec=new Rectangle(5,10);
        rec.Display();
        Console.WriteLine("The area of the Rectangle is "+rec.CalculateArea());
        Console.WriteLine("\n \n \n");

        //alternative
        Circle circle1=new Circle(20);
        circle.Display();
        Console.WriteLine("The area of the circle is "+    circle1.CalculateArea().ToString("F2"));

        Rectangle rectangle=new Rectangle(6,7);
        rectangle.Display();
         Console.WriteLine("The area of the Rectangle is "+rectangle.CalculateArea());


    }
}
}