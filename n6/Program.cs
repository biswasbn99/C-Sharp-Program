using System;

namespace Test
{
    class Neon
    {
        public static void Main()
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            int sum = 0;
            
            while (square > 0)
            {
                int R = square % 10;
                sum += R;
                square /= 10;
            }
            
            if (sum == num)
                Console.WriteLine(num + " is a Neon number");
            else
                Console.WriteLine(num + " is not a Neon number");
        }   
    }
}
