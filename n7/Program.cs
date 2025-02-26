using System;

namespace Test
{
    class Neon
    {
        public static void Main()
        {
            Console.Write("Enter a range: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All Neon Numbers within the range:");

            // Loop from 0 to the given range
            for (int i = 0; i <= num; i++)
            {
                int square = i * i;
                int sum = 0;

                // Sum the digits of the square of the number
                while (square > 0)
                {
                    int R = square % 10;
                    sum += R;
                    square /= 10;
                }

                // If sum of digits equals the number itself, it's a neon number
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
