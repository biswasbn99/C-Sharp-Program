/*Write a C# program to demonstrate multicast delegates with 4 methods (sum,sub,mul,div)
 that perform addition and subtraction.*/
 using System;
 namespace Test
 {
    public delegate void MyDelegate(int x,int y);
    public class Myclass
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine("The Sum of 2 numbers: "+(a+b));
        }
        public static void sub(int m, int n)
        {
            Console.WriteLine("The subtraction of 2 numbers : "+(m-n));
        }
        public static void Mul(int r,int s)
        {
            Console.WriteLine("The Multiplication of 2 numbers: "+(r*s));
        }
        public static void Div(int k, int p)
        {
            Console.WriteLine("The Divition of 2 numbers : "+(k/p));
        }

        public static void Main()
        {
            MyDelegate del=new MyDelegate(Sum);
            del+=sub;
            del+=Mul;
            del+=Div;
            del(10,5);
        }
    }
 }