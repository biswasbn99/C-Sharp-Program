/* 3. Write a C# program that prompts the user to enter their age. The program should classify the user into one of the following age groups and display the appropriate message:
•	Child: 0 - 12 years
•	Teenager: 13 - 19 years
•	Adult: 20 - 64 years
•	Senior: 65 years and above    ------>Using Switch Case Statement
  */



using System;

namespace Test{
    class Age{
        public static void Main(){
            Console.WriteLine("Enter your Age :");
        int n = Convert.ToInt32(Console.ReadLine());

        switch(n){
            case int x when x>=0 && x<=12:
            Console.WriteLine("Child");
            break;
            case int x when x>=13 && x<=19:
            Console.WriteLine("Teenager");
            break;
            case int x when x>=20 && x<=64:
            Console.WriteLine("Adult");
            break;
            default:
            Console.WriteLine("Senior");
            break;
        }
        }
    }
}