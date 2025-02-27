/*Print all Spy Number within a range */
using System;

namespace Test
{
    class SpyNumber
    {
        public static void Main()
        {
            Console.Write("Enter a range: ");
            int n = Convert.ToInt32(Console.ReadLine());

           Console.Write("All Spy Number  :");

            // Loop through numbers from 1 to n
            for (int num = 10; num <= n; num++)
            {
                int sum = 0;
                int product = 1;
                int originalNumber = num;

                // Loop through each digit of the number
                while (num > 0)
                {
                    int digit = num % 10;  // Get the last digit
                    sum += digit;          // Add the digit to the sum
                    product *= digit;      // Multiply the digit to the product
                    num /= 10;             // Remove the last digit
                }

                // Check if sum is equal to product
                if (sum == product)
                {
                    Console.Write(originalNumber + " ");
                }

                // Restore the value of num for the next iteration
                num = originalNumber;
            }
        }
    }
}
