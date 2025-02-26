/*Print all palindrome number under a range  */

using System;
namespace Test
{
    class Palindrome
    {
       public static void Main()
        {
            Console.Write("Enter a range: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Palindrome Number:");
            
            for (int i = 1; i <= num; i++)
            {
                int temp = i, rev = 0;
                while (temp != 0)
                {
                    int R = temp % 10;
                    rev = (rev * 10) + R;
                    temp /= 10;
                }
                
                if (rev == i)
                {
                    Console.Write(i +" ");
                }
            }
        }
    }
}
