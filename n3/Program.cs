/* Write a C# program that prompts the user to enter a positive integer N.
 The program should calculate and display the factorial of N.  */

 using System;
 namespace Test{
    class Factorial{
        public static void Main(){
            
            Console.Write("Enter a number: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int Fact=1;
            for(int i=1; i<=n; i++)
            {
               Fact *=i;
            }
            
            Console.Write("Factorial of "+ n +" is :"+ Fact);
        }
    }
 }