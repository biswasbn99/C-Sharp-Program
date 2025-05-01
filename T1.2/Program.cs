/*Write a C# program that takes three integer numbers as input and 
determines the largest.*/
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main(){
        Console.WriteLine("Enter 1st Enter :");
        int a=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter 2nd Enter :");
         int b=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter 3rd Enter :");
          int c=Convert.ToInt32(Console.ReadLine());

          if(a>b && a>c)
          {
            Console.WriteLine(a+" is the largest number.");
          }
          else if(b>a && b>c)
          {
            Console.WriteLine(b+" is the largest number.");
          }
          else
          {
            Console.WriteLine(c+ " is the largest number.");
          }
    }
}
}