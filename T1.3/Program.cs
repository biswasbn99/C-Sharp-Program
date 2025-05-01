/*Write a C# program that take an integer array from the user and find 
the second largest number and display the value if possible. */
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {

            Console.WriteLine("How many elements of the array?");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter all elements: ");
            int[] numbers=new int[n];
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine("Element-"+(i+1)+" : ");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array:");
            foreach(int number in numbers)
            {
                Console.Write(" "+number);
            }
            Console.WriteLine();
            Console.WriteLine("After sorting array : ");
            Array.Sort(numbers);
            foreach(int number in numbers)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Second largest number is :"+numbers[n-2]);
        }
    }
}