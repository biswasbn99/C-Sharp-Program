/*Write a C# program that counts the occurrences of duplicate 
elements within a given array.*/
using System;

namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            int[] numbers = {1,2,1,1,2,3,4,5,6,7,8,1,2,35,54,3,5,6,7,2};
            bool[] processed = new bool[numbers.Length]; // To track already processed elements

            for (int i = 0; i < numbers.Length; i++)
            {
                if (processed[i]) // Skip already processed elements
                {
                    continue;
                }

                int count = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count += 1;
                        processed[j] = true; // Mark this element as processed
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine( numbers[i] + " occurs " + count + " times");
                }
            }
        }
    }
}