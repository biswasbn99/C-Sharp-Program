//2 types of Conversion
/*Implicit/Automatic Conversion:
 char-->int-->long-->float-->double
*/
/*Explicit / Manual conversion:
double-->float-->long-->int-->char
*/

using System;
class Test{
    public static void Main(string[]args){

     int salary1= 35672;
     Console.WriteLine($"Salary={salary1}");
     double salary2= salary1;                  //Implicit Type Casting
     Console.WriteLine($"Salary={salary2}");

     double salary3=36754.45;
     Console.WriteLine(salary3);
     int salary4= (int)salary3;
     Console.WriteLine(salary4);

     int salary5=2345;//If we want to convert int =string
     string salary6=Convert.ToString (salary5);
     Console.WriteLine(salary6);
     Console.ReadKey();// Window stays open until a key is pressed
     double salary7=3456;
     int salary8= Convert.ToInt32(salary7);
Console.WriteLine(salary8);
Console.ReadKey();

 string input="34.5";//Exception Handling using TryParsr, It is used for string
 bool isAvailable=int.TryParse(input,out int result);
 Console.WriteLine($"number={result}");
 Console.WriteLine($"number={isAvailable}");

    }
}