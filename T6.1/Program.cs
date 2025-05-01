/*Write a simple C# program that defines a delegate called PrintMessage which takes a string 
parameter and returns string. Then, implement a method DisplayMessage that prints a given 
message to the console. Create an instance of the delegate and use it to call the 
DisplayMessage method.*/

using System;
namespace Test
{
    public delegate string PrintMessage(string message);
   public class Myclass
   {
     public static string DisplayMessage(string msg)
    {
       Console.WriteLine("Message : "+msg );
       return msg; 
    }

    public static void Main()
    {
        PrintMessage printMessage=new PrintMessage(DisplayMessage);
        printMessage("My Name is Bn");
    }
   }

}