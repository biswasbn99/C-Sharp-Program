/* Write a C# program that prompts the user to enter a student's score (an integer between 0 and 100). Based on the score, the program should determine and display the corresponding letter grade according to the following criteria:
•	A: 90 - 100
•	B: 80 - 89
•	C: 70 - 79
•	D: 60 - 69
•	F: Below 60 */

using System;
namespace students{
class Grade{

public static void Main()
{
    Console.WriteLine("Enter a score of a students:");
    int n=Convert.ToInt32(Console.ReadLine());

    if(n<=100 && n>=0){

if(n>=90 && n<=100){
Console.WriteLine("A");
}
else if(n>=80 && n<=89){
    Console.WriteLine("B");
}
else if(n>=70 && n<=79){
Console.WriteLine("C");
}
else if(n>=60 && n<=69){
Console.WriteLine("D");
}
else{
    Console.WriteLine("F");
}

    }
    else{
        Console.WriteLine("Your given Score is invalid");
    }
}
}
}