/* Imagine that you are writing a program that controls a conveyor belt in a factory.
You might create a method called Conveyor( ) that accepts the following commands as parameters:
 start, stop, forward, and reverse.The user passes  integers in Conveyor( )and show the 
 corresponding meassge and show all of the message and all of the assigned words.You can
  create an enumeration that assigns words to these values.  */
   using System;
   namespace Test{
    public class ConveyorFactory{
        public enum ConveyorBelt{
            start=1,
            stop,
            forward,
            reverse
        }
        //Print  Message according to user input
      public void Conveyor(int d){
        switch(d){
            case 1:
            Console.WriteLine("Starting Conveyor");
            break;
            case 2:
            Console.WriteLine("Stopping Conveyor");
            break;
            case 3:
            Console.WriteLine("Moving forward the Conveyor");
            break;
            case 4:
            Console.WriteLine("Moving reverse the Conveyor");
            break;

        }

      }
     //print all message
     public void DisplayAllMessage(){
        Console.WriteLine("Starting Conveyor");
        Console.WriteLine("Stopping Conveyor");
        Console.WriteLine("Moving Forward the Conveyor");
        Console.WriteLine("Moving Backward the  Conveyor");
     }
     //Print Assign word Under Enumeration
     public void DisplaysAll(){
        foreach(ConveyorBelt command in Enum.GetValues(typeof(ConveyorBelt))){
            Console.WriteLine(command);
        }
     }


    }
class Myclass{
    public static void Main(){
        ConveyorFactory c=new ConveyorFactory();
        //user input  a value 1 to 4 and print a message
        Console.WriteLine("Enter a number 1 to 4 :");
        int d=Convert.ToInt32(Console.ReadLine());
        c.Conveyor(d);
        Console.WriteLine();

        //print all of the message
        Console.WriteLine("For Printing all of the messages ,press \"Enter Key\"");
        Console.ReadKey();
        c.DisplayAllMessage();
        Console.WriteLine();
        //Print Assign word Under Enumeration
        Console.WriteLine("For Printing Assign word Under Enumeration ,press \"Enter Key\"");
        Console.ReadKey();
        c.DisplaysAll();

    }
}



   }