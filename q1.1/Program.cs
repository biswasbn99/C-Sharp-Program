using System;
namespace students
{
    class Grade
    {
        public static void Main()
        {
            Console.WriteLine("Enter a score of a student:");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case int x when x >= 90 && x <= 100:
                    Console.WriteLine("A");
                    break;
                case int x when x >= 80 && x <= 89:
                    Console.WriteLine("B");
                    break;
                case int x when x >= 70 && x <= 79:
                    Console.WriteLine("C");
                    break;
                case int x when x >= 60 && x <= 69:
                    Console.WriteLine("D");
                    break;
                case int x when x >= 0 && x < 60:
                    Console.WriteLine("Below 60");
                    break;
                default:
                    Console.WriteLine("Your given Score is invalid");
                    break;
            }
        }
    }
}