/*Write a C# program that print all the longest word from a given sentence.*/
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            int n = 1;
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("After Splitting, Words are :");
            foreach (string word in words)
            {
                Console.WriteLine(" " + word);
            }
            Console.WriteLine();
            string longestWord = " ";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }

            }

            for (int j = 0; j < words.Length; j++)
            {
                if (longestWord.Length == words[j].Length)
                {
                    Console.WriteLine("Longest Word(" + n + "): " + words[j]);
                    n++;
                }
            }
        }
    }
}