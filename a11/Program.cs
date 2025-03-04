/*Write a C# program that demonstrates array initialization, accessing elements, modifying an element,
 and retrieving the array's length*/
 using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            // Step 1: Declare and initialize the array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Step 2: Accessing elements
            int firstNumber = numbers[0]; // Accessing first element
            int thirdNumber = numbers[2]; // Accessing third element

            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Third Number: " + thirdNumber);

            // Step 3: Modifying an array element
            numbers[1] = 10; // Changing second element

            // Step 4: Display modified array
            Console.Write("Modified Array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // New line

            // Step 5: Get the array length
            int length = numbers.Length;
            Console.WriteLine("Array Length: " + length);
        }
    }
}
