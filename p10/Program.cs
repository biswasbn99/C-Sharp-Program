using System;

class Test{
    public static void Main(){
        int num1=20;
        int num2=6;

        int sum=num1+num2;
        Console.WriteLine("Addition: " +sum);
        int sub=num1-num2;
        Console.WriteLine("Subtraction: "+sub);
        int div=num1/num2; //if we print before point part only(interger value)
        Console.WriteLine("division :"+div);

        int rem=num1%num2;
        Console.WriteLine("Remainder: "+rem);
        double div1=(double)num1/num2;
        Console.WriteLine("Division: "+div1.ToString("F3"));
    }
}