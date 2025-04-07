/*

Write a C# program that demonstrates method overloading using a Calculator class. 
The Calculator class should have multiple Add methods:

1. A method to add two integers.
2. A method to add three integers (overloaded method).
3. A method to add two doubles (overloaded method).

In the Main method, call each overloaded Add method with appropriate arguments and print the 
results.
 */
 using System;
 namespace Test
 {
    public class Calculator
    {
        //add two Integer
        public int Add(int a, int b)
        {
            int sum=a+b;
            return sum;
        }
        //add three integer
        public int Add(int a, int b, int c)
        {
            int sum=a+b+c;
            return sum;
        }
        //add two double
        public double Add(double a, double b)
        {
            double sum=a+b;
            return sum;
        }
    }

    public class Myclass
    {
        public static void Main()
        {
            Calculator calculator=new Calculator();
            Console.WriteLine("Sum of two integer : "+calculator.Add(5,5));
            Console.WriteLine("Sum of three integer : "+calculator.Add(5,5,5));
            Console.WriteLine("Sum of two double : "+calculator.Add(5.5,5.5));
        }
    }
 }