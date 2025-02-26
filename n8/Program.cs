/* The number is duck number or not*/
using System;

namespace Test
{
    class Duck
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int temp = num;
            int d = 0;

            // Loop through each digit of the number
            for (temp = num; temp != 0; temp /= 10)
            {
                int R = temp % 10;

                // Check if any digit (except the first) is zero
                if (R == 0)
                {
                    d++;  // Set the flag to indicate it's a Duck Number
                    break;
                }
            }

            // Output whether the number is a Duck Number or not
            if (d == 1 && num > 9)  // Ensure number is not single digit
            {
                Console.WriteLine(num + " is a Duck Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Duck Number");
            }
        }
    }
}
