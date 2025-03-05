/* Create an enumeration DaysOfWeek to represent the days of the week (Monday to Sunday).
 Then write a C# program that prompts the user to enter a number (1 to 7) and displays the
  corresponding day of the week using the enumeration*/
  
  using System;

namespace Test
{
    public enum DaysOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Days
    {
        public static void Main()
        {
            Console.Write("Enter a number from 1 to 7: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1 && n <= 7)
            {
                DaysOfWeek day = (DaysOfWeek)n;
                Console.WriteLine("The corresponding day is: " + day);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            }
        }
    }
}
