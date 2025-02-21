using System;

class Test{
    public static void Main(){
        
    string StudentName;
    int StudentAge;
  
    bool isregister;

    Console.WriteLine("Enter Your Name:");
    StudentName=Console.ReadLine();

    Console.WriteLine("Enter Your Age:");
    StudentAge=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Your CGPA:");
double gpa=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Have You Alrady registered :");
isregister=Convert.ToBoolean(Console.ReadLine());//Input true or false

    Console.WriteLine("My Name is "+StudentName);
Console.WriteLine("My age is "+StudentAge);
Console.WriteLine("My CGPA is "+ gpa);
Console.WriteLine("I am is resgistered: "+isregister);

    }
}