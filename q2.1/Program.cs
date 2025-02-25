using System;

namespace Test{
class Number{
    public static void Main(){
     
     Console.WriteLine("Enter an integer :");
     int n=Convert.ToInt32(Console.ReadLine());

     switch(n){
        case int x when x%2 == 0:
        Console.WriteLine(n  +  "  is even number !!");
        break;

        default:
        Console.WriteLine(n  +  "   is is odd number !!");
        break;
     }

    }
}
}










































































































