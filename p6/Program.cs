using System;

class Test{

    public static void Main(string[]args){

        string university = "IUBAT";
        Console.WriteLine(university);
        university = "Oxford university";
        Console.WriteLine(university);

        const string nationality ="Bangladeshi"; //we can't use same variable again
        Console.WriteLine(nationality);

        int num1=10,num2=10,num3=10;
        int sum1=num1+num2+num3;
        Console.WriteLine($"Sum1={sum1}");

int num4,num5,num6;
         num4=num5=num6=30;
        int sum2=num4+num5+num6;
        Console.WriteLine($"Sum2= {sum2}");

    }
}