/* Print all armstrong number within a range */

using System;

namespace Test
{
    class Armstrong
    {
        public static void Main()
        {
            // Ask for the range
            Console.Write("Enter a range: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            // Print header for Armstrong numbers
            Console.Write("All Armstrong Numbers: ");
            
            // Loop through numbers from 1 to n
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int originalNum = num;  // Store the original number
                
                // Find the number of digits
                int length = num.ToString().Length;

                // Loop to extract each digit and calculate the sum of powers
                while (num > 0)
                {
                    int digit = num % 10;  // Get the last digit
                    sum += (int)Math.Pow(digit, length);  // Add the power of the digit to the sum
                    num /= 10;  // Remove the last digit
                }

                // After processing all digits, check if the sum equals the original number
                if (sum == originalNum)
                {
                    Console.Write(originalNum + " ");
                }
                
                // Restore num value for next iteration (important!)
                num = originalNum; 
            }
        }
    }
}
