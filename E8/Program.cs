/* Imagine that you are writing a program that controls a conveyor belt in a factory.
You might create a method called Conveyor( ) that accepts the following commands as
  parameters: start, stop, forward, and reverse. Instead of passing Conveyor( ) integers,
   such as 1 for start, 2 for stop, and so on, which is error-prone, you can create an
   enumeration that assigns words to these values.  */
   using System;
   namespace Test{
    public class ConveyorFactory{
        public enum ConveyorBelt{
            start=1,
            stop,
            forward,
            reverse
        }
      public void Conveyor(ConveyorBelt d){
        switch(d){
            case ConveyorBelt.start:
            Console.WriteLine("Starting Conveyor");
            break;
            case ConveyorBelt.stop:
            Console.WriteLine("Stopping Conveyor");
            break;
            case ConveyorBelt.forward:
            Console.WriteLine("Moving forward the Conveyor");
            break;
            case ConveyorBelt.reverse:
            Console.WriteLine("Moving reverse the Conveyor");
            break;

        }

      }

    }
class Myclass{
    public static void Main(){
        ConveyorFactory c=new ConveyorFactory();
        c.Conveyor(ConveyorFactory.ConveyorBelt.start);
        c.Conveyor(ConveyorFactory.ConveyorBelt.stop);
        c.Conveyor(ConveyorFactory.ConveyorBelt.forward);
        c.Conveyor(ConveyorFactory.ConveyorBelt.reverse);
    }
}



   }