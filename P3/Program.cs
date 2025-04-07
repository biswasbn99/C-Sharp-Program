/*Create a class Shape with multiple overloaded versions of a method Area(). Implement the
 following overloads:
- One that takes circle’s radius and returns its area.
- Another that takes rectangle’s width and height and returns its area.
- One that takes square’s length of one line and returns its area.

Write a C# program that demonstrates **compile-time polymorphism** by calling each version of the
 Add() method.
 */
using System;
namespace Test
{
    public class Shape
    {
        public double Area(double radius)
        {
            return Math.PI*radius*radius;
        }
        public double Area(double weight,double height)
        {
            return weight*height;
        }
        public double Area(int side)
        {
            return side*side;
        }
    }

    public class Myclass
    {
        public static void Main()
        {
            Shape shape=new Shape();
            Console.WriteLine("The Area of the circle : "+shape.Area(4.5));
               // show result after 2 decimal point
            Console.WriteLine("The Area of the circle : "+shape.Area(4.5).ToString("F2"));
            Console.WriteLine("The Area of the Rectangle : "+shape.Area(5.5,5.5));
            Console.WriteLine("The Area of the Square : "+shape.Area(10));
        }
    }
}