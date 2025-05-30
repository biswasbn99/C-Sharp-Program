/*Given an array named words = { "cherry", "apple", "blueberry" },
Write a C# program to sort the words in ascending alphabetical order and display the result.*/

using System;
using System.Linq;

public class Myclass
{
    public static void Main()
    {
        string[] words = { "cherry", "apple", "blueberry" };

        var sortWords = from w in words
                        orderby w
                        select w;

        Console.WriteLine("The sorted list of words:");
        foreach (var w in sortWords)
        {
            Console.WriteLine(w+" ");
        }
    }
}
