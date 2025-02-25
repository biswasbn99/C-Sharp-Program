/* Write a C# program that prompts the user to enter their age. The program should classify the user into one of the following age groups and display the appropriate message:
•	Child: 0 - 12 years
•	Teenager: 13 - 19 years
•	Adult: 20 - 64 years
•	Senior: 65 years and above
 */



using System;

namespace Test{

    class Age{
        public static void Main(){

    Console.WriteLine("Enter your age : ");
    int n= Convert.ToInt32(Console.ReadLine());
      
      if(n>=0 && n<=12){
       Console.WriteLine("Child");
      }
      else if(n>=13 && n<=19){
        Console.WriteLine("Teenager");
      }
      else if(n>=20 && n<=64){
        Console.WriteLine("Adult");
      }
      else{
        Console.WriteLine("Senior");
      }

        }
        
    }
}