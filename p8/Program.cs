using System;

class Test{
    public static void Main(string[]orgs){
    string name;
    int age;
    double salary;

        Console.Write("Enter your Name:");
        name=Console.ReadLine();
        Console.WriteLine("Name:"+name);
        Console.Write("Enter your Age:");
        age=int.Parse(Console.ReadLine());
        Console.WriteLine("Age:"+age);
        Console.Write("Enter Your salary:");
        salary=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Salary:"+salary);
    }
}