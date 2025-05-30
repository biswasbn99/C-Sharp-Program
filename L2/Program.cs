/*Given an array named numbers with values {5, 10, 8, 3, 6, 12, 15, 16},

Search and display all numbers that are divisible by 2

Display the output in ascending order

Finally, write a valid C# program that performs the above task and displays the output. */

using System;
using System.Linq;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12, 15, 16 };

            var numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            foreach (var i in numQuery1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
