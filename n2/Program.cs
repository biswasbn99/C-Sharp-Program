using System;

namespace Test
{
    class Prime
    {
        public static void Main()
        {
            Console.Write("Enter a range: ");
            int n = Convert.ToInt32(Console.ReadLine());
          Console.Write("Prime Number:");
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true; // Initialize isPrime for each number

                for (int d = 2; d <= (i / 2); d++)
                {
                    if (i % d == 0)
                    {
                        isPrime = false;
                        break; // Exit loop early if not prime
                    }
                }

                if (isPrime)
                {
                    
                    Console.WriteLine( + i);
                }
            }
        }
    }
}
