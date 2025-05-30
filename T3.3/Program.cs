/*
3. Write a C# program where the bases class is shape. And the derived classes are of 
different shape. (Circle, Rectangle, Triangle etc.) The member method of the the 
derived classes are going to calculate the area of the shape. 
For example,  
Circle class will calculate the area of the circle, rectangle class or triangle will also 
do the same.*/
using System;
namespace Test
{
    public abstract class Shape
    {
        public abstract void CalculateAre();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }


        public override void CalculateAre()
        {
            Console.WriteLine("Area of a circle " + Math.PI * Radius*Radius);

        }
    }

    public class Rectangle : Shape
    {
        double Length { get; set; }
        double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length =length ;
            Width = width;

        }
        public override void CalculateAre()
        {
            Console.WriteLine("The Area of a rectangle :" + (Length * Width));
        }
    }
    public class Triangle : Shape
    {
        double Base { get; set; }
        double Height { get; set; }
        public Triangle(double base1, double height)
        {
            Base = base1;
            Height = height;
        }
        public override void CalculateAre() {

            Console.WriteLine("The area of a triangle: " + (0.5 * Base * Height));
        }
    }

    public class Myclass
    {
        public static void Main()
        {
            Circle circle = new Circle(10);
            circle.CalculateAre();
            Rectangle rectangle = new Rectangle(10, 30);
            rectangle.CalculateAre();
            Triangle triangle=new Triangle(10, 20);
            triangle.CalculateAre();
        }
    }
}

