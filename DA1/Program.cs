/* Write a C# program to demonstrate the use of a delegate that takes a string parameter
 and displays a message using a method assigned to the delegate.*/
using System;
namespace Test
{
    public delegate void MyDelegate(string message);
    public class Myclass
    {
        public static void MyBio(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Main()
        {
            MyDelegate myDelegate=new MyDelegate(MyBio);
            myDelegate("My Name is BN");
        }
    }
}