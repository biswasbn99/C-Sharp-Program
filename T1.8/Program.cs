/*Write a C# program to accept a coordinate point in an XY 
coordinate system and determine in which quadrant the coordinate point lies.*/
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            Console.WriteLine("Enter X Co-ordinate: ");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y Co-ordinate: ");
            double y=Convert.ToDouble(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("The point lies in Quadrant-I");
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("The point lies in Quadrant-II");
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("The point lies in Quadrant-III");
            }
            else if(x>0 && y<0)
            {
                Console.WriteLine("The point lies in Quadrant-VI");
            }
            else if(x==0 && y==0)
            {
                Console.WriteLine("Point lies at the origin");
            }
            else if(x==0)
            {
                Console.WriteLine("Point lies on the Y-axis.");
            }
            else if(y==0)
            {
                Console.WriteLine("Point lies on the X-axis.");
            }

        }
    }
}