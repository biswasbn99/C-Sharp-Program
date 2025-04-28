/*1. You are developing a basic calculator program that performs division. The program should 
handle the following cases:If the user attempts to divide by zero, it should catch an
ArithmeticException and display an appropriate message.If the user enters invalid input
 (e.g., non-numeric values), it should catch a NumberFormatException and display a user-friendly
error message.For any other unexpected error, it should display a general error message.
Write a program that:
 Takes two numbers as input from the user.
 Attempts to divide the first number by the second number.
 Handles the above exceptions gracefully and continues to prompt the user for valid input 
until successful. */

using System;
namespace Test
{
    public class Result
    {
        public double Div(double x,double y)
        {
            return x/y;
        }
    }
    public class Myclass
    {
        public static void Main()
        {
            try{
                Console.WriteLine("Enter a Numerator : ");
                double x= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a Denominator: ");
                double y=Convert.ToDouble(Console.ReadLine());
                Result res= new Result();
                double result=res.Div(x,y);
                Console.WriteLine("Results : "+result);
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("ERROR!! Denominator cannot be Zero.");
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR !! Invaild input.Please ,Enter valid double numbers");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: "+ex.Message);
            }
            finally
            {
              Console.WriteLine("Program Finished...");
            }
    }
}
}
