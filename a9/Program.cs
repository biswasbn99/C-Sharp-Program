/*Write a C# program where a user initializes a `List<int>`, adds an element, inserts at index 
`2`, accesses the first element, iterates and prints all, removes a specific value and
 the first element, then displays the final list. */

using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            // Step 1: Initialize a List<int> with user input
            Console.WriteLine("How many elements?");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            Console.WriteLine("Enter all elements to initialize the list:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element-" + (i + 1) + ": ");
                int element = Convert.ToInt32(Console.ReadLine());
                numbers.Add(element);
            }
            Console.WriteLine("Initialized List: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 2: Add an element to the list & display it
            Console.Write("Enter an element to add to the list: ");
            int addElement = Convert.ToInt32(Console.ReadLine());
            numbers.Add(addElement);
            Console.WriteLine("List after adding " + addElement + ": ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 3: Insert an element at index 2 & display it
            Console.Write("Enter an element to insert at index 2: ");
            int insertElement = Convert.ToInt32(Console.ReadLine());
            numbers.Insert(2, insertElement);
            Console.WriteLine("List after inserting " + insertElement + " at index 2: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 4: Access and display the first element
            int firstNumber = numbers[0];
            Console.WriteLine("First Number: " + firstNumber);

            // Step 5: Iterate and display all elements
            Console.WriteLine("List Elements: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 6: Remove an element by value & display it
            Console.Write("Enter an element to remove from the list: ");
            int removeElement = Convert.ToInt32(Console.ReadLine());
            numbers.Remove(removeElement);
            Console.WriteLine("List after removing " + removeElement + ": ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 7: Remove an element by index & display it
            numbers.RemoveAt(0);
            Console.WriteLine("List after removing the first element: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Step 8: Display the final state of the list
            Console.WriteLine("Final List: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
