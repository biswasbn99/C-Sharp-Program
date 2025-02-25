/*2. Write a C# program that prompts the user to enter an integer.
 The program should determine whether the number is even or odd and display 
 the appropriate message. ---->using If else statement*/

using System;

class Number{
    public static void Main(){
       
       Console.WriteLine("Enter an Integer : ");
       int n=Convert.ToInt32(Console.ReadLine());

       if(n%2 == 0){
        Console.WriteLine("The number is even !!");
       }
       else{
        Console.WriteLine("The number is odd !!");
       }

    }
}