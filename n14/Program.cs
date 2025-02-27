/*The number is spy number or not*/
using System;

namespace Test
{
    class SpyNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            int product = 1;
            int num= n;

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
                Console.WriteLine(n + " is a Spy Number.");
            }
            else
            {
                Console.WriteLine(n + " is not a Spy Number.");
            }
        }
    }
}
