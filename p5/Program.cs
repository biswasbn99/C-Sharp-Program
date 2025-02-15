using System;

class Assignment
{
    public static void Main(string[] args)
    {
        string name = "Apple iPhone 14";
        double price=320.5;
        string category="smart phone";
        bool isAvailable=true;
        int sold=5;


        // Using concatenation
        Console.WriteLine("Name : " + name);

        // OR using string interpolation (Recommended)
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Price:$ {price}");
        Console.WriteLine($"Category:{category}");
        Console.WriteLine("Sold:"+sold);
        Console.WriteLine($"Available:{isAvailable}");
    }
}
