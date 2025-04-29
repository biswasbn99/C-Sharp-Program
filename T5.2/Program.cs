/*You are designing a simple banking application. The application should allow users to withdraw
money from their accounts. The following rules apply:If the withdrawal amount exceeds the account
balance, it should throw an InsufficientFundsException (custom exception).If the withdrawal
amount is negative, it should throw an IllegalArgumentException.Any other unexpected errors
should be caught and handled gracefully.Write a program to implement this functionality. Ensure
that:
 A custom InsufficientFundsException is defined and thrown where appropriate.
 Both specific and generic exceptions are handled.
 Proper error messages are displayed to the user. */

using System;
namespace Test

{
    public class InsufficientFundsException:Exception
    {
        public InsufficientFundsException(string message):base(message) { }
    }

    public class Myclass
    {
        public static void Main()
        {
           try{
             Console.WriteLine("Submit money in your account : ");
            double balance =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now ,Your Current account Balance is : "+balance);
            
           Console.WriteLine("Enter your withdrawable balance : ");
           double n=Convert.ToDouble(Console.ReadLine());
           if(n>balance)
           {
            throw new InsufficientFundsException("Insufficient Balance!! Please ,Enter less withrawable amount.");
           }
           if(n<0)
           {
            throw new ArgumentException("Withdrawal amount cannot be negative.Please ,Enter a valid Withdrawable amount.");
           }
           double availablebalance=balance-n;
           Console.WriteLine("Your available balance is : "+availablebalance);
           }
           catch(InsufficientFundsException ex)
           {
            Console.WriteLine("ERROR!! "+ex.Message);
           }
           catch(ArgumentException ex)
           {
            Console.WriteLine("ERROR!! "+ex.Message);
           }
           catch(FormatException)
           {
            Console.WriteLine("ERROR!! Invalid Input .please, enter a valid number");
           }
           catch(Exception ex)
           {
            Console.WriteLine("An unexpected error occurred: "+ex.Message);
           }
           finally
           {
            Console.WriteLine("Transaction Completed.");
           }
        }
    }
}