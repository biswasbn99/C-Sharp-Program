/*Write a C# program that will search an element from a given array.  */
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            Console.WriteLine("How many elements???");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter all Array elements: ");
            int[] numbers=new int[n];
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine("Element-"+(i+1)+" :");
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Array:");
            foreach(int number in numbers)
            {
                Console.Write(" "+number);
            }
            Console.WriteLine("\n Search a number: ");
            int m=Convert.ToInt32(Console.ReadLine());
            bool found= false;
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]==m)
                {
                    Console.WriteLine(m+" is found");
                    found=true;
                    break;
                }
                
            }
            if(!found)
            {
                Console.WriteLine(m+ " is not found");
            }
        }
    }
}