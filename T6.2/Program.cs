/* Write a delegate CalculateCircleArea that takes a double parameter (radius) and returns a 
double (the area of the circle). Write a method GetArea that calculates the area of a circle 
using the formula π * radius^2. Create an instance of the delegate and use it to calculate and 
print the area for a circle with a radius of 7.*/
using System;
namespace Test

{
    public delegate double CalculateCircleArea(double radius);
    public class Myclass
    
{
    public static double GetArea(double red)
    {
        Console.WriteLine("The circle radius is : "+red);
        double area =Math.PI*red*red;
        Console.WriteLine("The area of a circle is : "+area.ToString("F2"));
        return area;
    }

    public static void Main()
    {
        CalculateCircleArea calculateCircleArea=new CalculateCircleArea(GetArea);
        calculateCircleArea(7);
    }
}
}