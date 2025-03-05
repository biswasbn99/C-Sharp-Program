/*Create an enumeration DaysOfWeek to represent the days of the week (Monday to Sunday).
Then write a C# program that and displays all day of the week using the enumeration */
using System;
using Test;
namespace Test{
    public class Enumeration{
        public enum DaysOfWeek{
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void Days(DaysOfWeek d){
            switch(d){
                case DaysOfWeek.Monday:
                Console.WriteLine("This is Monday");
                break;
                case DaysOfWeek.Tuesday:
                Console.WriteLine("This is Tuesday");
                break;
                case DaysOfWeek.Wednesday:
                Console.WriteLine("This is Wednesday");
                break;
                case DaysOfWeek.Thursday:
                Console.WriteLine("This is Thursday");
                break;
                case DaysOfWeek.Friday:
                Console.WriteLine("This is Friday");
                break;
                case DaysOfWeek.Saturday:
                Console.WriteLine("This is Saturday");
                break;
                case DaysOfWeek.Sunday:
                Console.WriteLine("This is Sunday");
                break;
            }
        }
    }
}
class Myclass{
    static void Main(){
        Enumeration c=new Enumeration();
       
        c.Days(Enumeration.DaysOfWeek.Monday);
        c.Days(Enumeration.DaysOfWeek.Tuesday);
        c.Days(Enumeration.DaysOfWeek.Wednesday);
        c.Days(Enumeration.DaysOfWeek.Thursday);
        c.Days(Enumeration.DaysOfWeek.Friday);
        c.Days(Enumeration.DaysOfWeek.Saturday);
        c.Days(Enumeration.DaysOfWeek.Sunday);
    }

}