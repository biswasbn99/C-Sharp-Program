


using System;
 using System.Linq;
namespace Test
{
    class Frequency
    {
        public static void Main()
        {
            int[] num = { 23, 24, 45, 50, 49, 24, 24, 50, 23, 24 };
            bool[] counted = new bool[num.Length]; // To track counted values

            for (int i = 0; i < num.Length; i++)
            {
                if (counted[i]) continue; // Skip if already counted

                int count = 1; // Start count at 1 (including the number itself)

                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        counted[j] = true; // Mark duplicate as counted
                    }
                }

                Console.WriteLine("Value: " + num[i] + " Frequency: " + count);
            }
        }
    }
}
