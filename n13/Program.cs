/* Print all Perfect number within a range */


using System;

namespace Test
{
    class PerfectNumber
    {
        public static void Main()
        {
            Console.Write("Enter a range: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            // Print header for perfect numbers
            Console.Write("All Perfect numbers: ");

            // Outer loop to iterate through numbers from 1 to n
            for (int num = 1; num <= n; num++)
            {
                int sum = 0;

                // Inner loop to find divisors of 'num'
                for (int i = 1; i <= num / 2; i++)  // Check divisors only up to num/2
                {
                    if (num % i == 0)
                    {
                        sum += i;  // Add divisor to the sum
                    }
                }

                // After calculating sum of divisors, check if it's a perfect number
                if (sum == num)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
