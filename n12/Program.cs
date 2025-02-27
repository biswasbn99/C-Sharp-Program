/* The number is perfect number or not*/

using System;

namespace Test
{
    class PerfectNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            // Find the sum of divisors excluding the number itself
            for (int i = 1; i <= num / 2; i++)  // Check divisors only up to num/2
            {
                if (num % i == 0)
                {
                    sum += i;  // Add divisor to the sum
                }
            }

            // Check if the sum of divisors equals the number
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number.");
            }
        }
    }
}
