/*Write a C# program that creates an array of integers with a size of 5. Prompt
the user to input an index to access an element from the array. Handle the
**IndexOutOfRangeException** if the user enters an index that is outside the valid
range of the array, and display an appropriate error message. */
using System;
namespace Test
{
    public class ArrayClass
    {
        public static void Main()
        {
            int[] numbers={2,4,6,8,10};
            try
            {
                Console.WriteLine("Enter an index (0-4)..");
                int n=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The value of Index--"+n+" : "+numbers[n]);

         }
         catch(IndexOutOfRangeException)
         {
            Console.WriteLine("ERROR!! Index out of range .Please, Enter a valid index(number) bewteen 0 to 4");
         }
         catch(FormatException)
         {
            Console.WriteLine("ERROR!! Invalid input.Please ,use valid integer number as input ");
         }
         catch(Exception ex)
         {
            Console.WriteLine("An Unexpected Error Occured : "+ex.Message);
         }
         finally
         {
            Console.WriteLine("Program finished....");
         }
        }
    }
}
