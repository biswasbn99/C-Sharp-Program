/*print multidimentional Array to get input from user  */
using System;

namespace Test
{
    class Matrix
    {
        public static void Main()
        {
            Console.Write("How many rows---->");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("How many columns----->");
            int m = Convert.ToInt32(Console.ReadLine());
            
            int[,] matrix = new int[n, m];
            
            Console.WriteLine("Enter the elements of the matrix:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("The Matrix is:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
