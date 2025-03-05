/* Create an enumeration DaysOfWeek to represent the days of the week (Monday to Sunday).
 Then write a C# program that prompts the user to enter a number (1 to 7) and displays the
  corresponding day of the week using the enumeration*/
  using System;
  namespace Test{
    public class Enumeration{
        public enum DaysOfWeek{
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
    

    public void Days(int d){
        switch(d){
            case 1:
            Console.WriteLine("This is Monday");
            break;
            case 2:
            Console.WriteLine("This is Tuesday");
            break;
            case 3:
            Console.WriteLine("The is Wednesday");
            break;
            case 4:
            Console.WriteLine("This is Thursday");
            break;
            case 5:
            Console.WriteLine("This is Friday");
            break;
            case 6:
            Console.WriteLine("This is Saturday");
            break;
            case 7:
            Console.WriteLine("This is Sunday");
            break;
            default:
            Console.WriteLine("It is Invalid number!!Please enter a number between 1 to 7");
            break;
        }
    }
    public void DisplaysAll(){
        foreach(DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
           Console.WriteLine(day); 
        }
    }
    }
    class Myclass{
        static void Main(){
            Enumeration c=new Enumeration();
            Console.WriteLine("Enter a number between 1 to 7 :");
            int d=Convert.ToInt32(Console.ReadLine());
            c.Days(d);

            Console.WriteLine("\n \nTo display all days ,press Enter");
            Console.ReadKey();
            //Print all of the days
            Console.WriteLine("\n All days of the week:");
            c.DisplaysAll();
        }
    }
  }