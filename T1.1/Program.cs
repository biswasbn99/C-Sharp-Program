/*Write a C# program to determine whether a given year is a leap year 
or not. */
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            Console.WriteLine("Enter a year:");
            int year =Convert.ToInt32(Console.ReadLine());
            if((year%4==0 && year%100!=0)||(year%400==0))
            {
                Console.WriteLine(year+" is a leap year....");
            }
            else
            {
                Console.WriteLine(year+" is not a leap year....");
            }
        }
    }
}