/* The number is armstrong or not */

using System;

namespace Test
{
    class Armstrong
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;  // Store the original number
            int sum = 0;
            int length = num.ToString().Length;

            while (num > 0)
            {
                int digit = num % 10;
                sum +=(int)Math.Pow(digit, length);  // Cast the result to int
                num /= 10;
            }

            if (sum == n)  // Compare with the original number
            {
                Console.WriteLine(n + " is an Armstrong Number!!");
            }
            else
            {
                Console.WriteLine(n + " is not an Armstrong Number!!");
            }
        }
    }
}
