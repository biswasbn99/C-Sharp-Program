using System;

namespace Test
{
    class Duck
    {
        public static void Main()
        {
            Console.Write("Enter a range: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("All Duck Numbers: ");
            
            // Loop through the range from 10 to num
            for (int i = 10; i <= num; i++)
            {
                int temp = i; // Initialize temp to the current number
                int d = 0; // Flag to indicate if it's a Duck Number

                // Loop through each digit of the number
                for (temp = i; temp != 0; temp /= 10)
                {
                    int R = temp % 10; // Get the last digit

                    // Check if the number contains a zero (excluding the first digit)
                    if (R == 0)
                    {
                        d++;  // Mark it as a Duck Number
                        break; // Stop further checking as we found a zero
                    }
                }

                // If it's a Duck Number, print it
                if (d == 1 && i>9) 
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
