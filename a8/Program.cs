/*Write a C# program to demonstrate `List<T>` operations: initialize `{1,2,3,4,5}`,
 add `6`, insert `10` at index `2`, access the first element, iterate and print all,
 remove `10` and the first element, then display the final list. */

 using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            // Step 1: Initialize a List<int> with some values
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Step 2: Add an element to the list
            numbers.Add(6);
            Console.WriteLine("\nList after adding 6: ");
            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }

            // Step 3: Insert an element at index 2
            numbers.Insert(2, 10);
            Console.WriteLine("\nList after inserting 10 at index 2: ");
            foreach (int number in numbers)
            {
                Console.Write(number+ " " );
            }

            // Step 4: Access and display the first element
            int firstNumber = numbers[0];
            Console.WriteLine("\nFirst Number: " + firstNumber);

            // Step 5: Iterate and display all elements
            Console.WriteLine("\nList Elements: ");
            foreach (int number in numbers)
            {
                Console.Write(number+ " ");
            }

            // Step 6: Remove an element by value
            numbers.Remove(10);
            Console.WriteLine("\nList after removing 10: ");
            foreach (int number in numbers)
            {
                Console.Write(number+ " ");
            }

            // Step 7: Remove an element by index
            numbers.RemoveAt(0);
            Console.WriteLine("\nList after removing the first element: ");
            foreach (int number in numbers)
            {
                Console.Write(number+ " ");
            }

            // Step 8: Display the final state of the list
            Console.WriteLine("\nFinal List: ");
            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }
        }
    }
}
