/*Create a class Rectangle with two properties Length and Width. These properties
should ensure that negative values are not allowed. If a user tries to set a negative value
for either Length or Width, it should automatically default to 0. Write a method 
GetArea() that returns the area of the rectangle.*/
using System;

namespace Test
{
    class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                    length = value;
                else
                    length = 0; // Default to 0 if negative
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    width = 0; // Default to 0 if negative
            }
        }

        public Rectangle(double length, double width) // Parameterized Constructor
        {
            Length = length;
            Width = width;
        }

        public double GetArea() // Return area of rectangle
        {
            return Length * Width;
        }
    }

    class Program
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(10, -5);
            Console.WriteLine("Length: " + r.Length);
            Console.WriteLine("Width: " + r.Width);
            Console.WriteLine("Area of Rectangle: " + r.GetArea());
        }
    }
}
