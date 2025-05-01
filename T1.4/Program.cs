/*Write a C# program that print the longest word from a given 
sentence.*/
using System;
namespace Test
{
    public class Myclass
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sentence: ");
         string sentence=Console.ReadLine();
         string[] words=sentence.Split(' ');
         Console.WriteLine("After Splitting, Words are :");
         foreach (string word in words)
         {
            Console.WriteLine(" "+word);
         }
         Console.WriteLine();
         string longestWord=" ";
         for(int i=0;i<words.Length;i++)
         {
            if(words[i].Length>longestWord.Length)
            {
                longestWord=words[i];
            }
            
         }
         Console.WriteLine("Longest word is :"+longestWord);
        }
    }
}