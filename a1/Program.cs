/*Declare an array with assign value */
using System;

namespace Test
{
    class Element
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };
            string[] names = { "Ali", "Abul", "Alex", "Rabi" };
            
            string[] Fruits = { "Apple", "Orange", "Mango", "Banana" };
            int[] Evens = { 2, 4, 6, 8,10 }; 
            
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", names));
            
            Console.WriteLine("All Fruits Name:");
            // Using for loop ,Print the array
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine(" " + Fruits[i]);
            }
            
            Console.WriteLine("All Even number:");
            // Using foreach loop ,Print the array
            foreach (int even in Evens)
            {
                Console.Write(" "+even);
            }
        }
    }
}