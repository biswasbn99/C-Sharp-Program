/*Write a C# program that prompts the user to enter two integers. Perform a
division of the two numbers and handle the **DivideByZeroException** if the user
enters 0 as the denominator. Display an appropriate error message and ensure the
program doesn’t crash. */
using System;
namespace Test
{
    public class Result
    {
        public int Div(int x,int y)
        {
           return x/y; 
        }
    }
    public class Myclass
    {
        public static void Main()
        {
            try{
                Console.WriteLine("Enter the Numerator : ..... ");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Denominator :....");
                int y=Convert.ToInt32(Console.ReadLine());
                Result Res=new Result();
                int result=Res.Div(x,y);
                Console.WriteLine("Result: "+result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error !!!   Denominator can't be Zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR!! Invaild Input. Please ,Input valid integer numbers only.");
            }
            ///i.e.,when we give a large number (Out of range like: 222222222222222234)
            catch(Exception ex)
            {
                Console.WriteLine("An unexpected error occurred : "+ ex.Message);
            }
            Console.WriteLine("Program Completed..");

        }

    
    }
}
