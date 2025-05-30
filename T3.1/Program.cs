/*Write a C# program where input type of the shape output is the area of that shape. */
using System;
namespace Test
{
    public class AllShap
    {
        public static void Main()
        {
            Console.WriteLine("Enter Input 1 for Triangle.... ");
            Console.WriteLine("Enter Input 2 for Square.... ");
            Console.WriteLine(" Enter Input 3 for Rectangle ...");
            int n=Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    double p = 20;
                    double m = 30;
                    Console.WriteLine("Area of Triangle :" + (0.5 * 20 * 30));
                    break;
                    case 2:
                    Console.WriteLine("Enter Side length:");
                    double k=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of a Square: " + (k * k));
                    break;  
                    case 3:
                    double length = 10;
                    double width = 20;
                    Console.WriteLine("Area of a Rectangle :"+(length * width));
                    break;
            }
        }
    }
}