/*Given two arrays:

numA = { 0, 2, 4, 5, 6, 8, 9 }

numB = { 1, 3, 5, 7, 8 }

Write a C# program to find and display all pairs (a, b) such that a < b where a comes
 from numA and b comes from numB.

*/

using System;
using System.Linq;

public class Myclass
{
    public static void Main()
    {
        int[] numA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numB = { 1, 3, 5, 7, 8 };

        var pairs = from a in numA
                    from b in numB
                    where a < b
                    select new { a, b };

        Console.WriteLine("Pairs where a < b:");
        foreach (var pair in pairs)
        {
            Console.WriteLine(pair.a + " < " + pair.b);
        }
    }
}
