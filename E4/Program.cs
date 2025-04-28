/*Create a custom exception class NegativeNumberException that is thrown
when a negative number is entered by the user. Write a program that takes an integer
input from the user and throws the custom exception if the input is negative. Catch the
custom exception and display an error message to the user.*/
using System;
using Test;
namespace Test
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) :base(message) { }
    }
   
   public class Myclass
   {
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter a positive Integer: ");
            int number=Convert.ToInt32(Console.ReadLine());

            if(number<0)
            {
                throw new NegativeNumberException("Negative numbers are not allowed.");
            }
            Console.WriteLine("You Entered : "+number);
        }
        catch (NegativeNumberException ex)
        {
            
            Console.WriteLine("ERROR!! "+ex.Message);

        }
        catch(FormatException)
        {
          Console.WriteLine("ERROR!! Invalid input. Please, Enter a valid Integer ");
        }
        catch(Exception ex)
        {
            Console.WriteLine("An unexpected error Occurred : "+ex.Message);
        }
        finally
        {
            Console.WriteLine("The Program finished..");
        }
    
   }
   }
}
