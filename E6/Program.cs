/* Create an enumeration TrafficLight with values Red, Yellow, and Green. Write a C# program
 that simulates a simple traffic light system where based on the current value of TrafficLight,
  the program prints different messages for each light color.*/

  using System;
  namespace Test{
   public class LightSystem{
    public enum TrafficLight{
        Red=1,
        Yellow,
        Green
    }
    public void PrintMessage(TrafficLight d){
        switch(d){
            case TrafficLight.Red:
            Console.WriteLine("The light is Red");
            break;
            case TrafficLight.Yellow:
            Console.WriteLine("The light is Yellow");
            break;
            case TrafficLight.Green:
            Console.WriteLine("The light is Green");
            break;
        }
    }
   }

 class Myclass{
    public static void Main(){
        LightSystem c=new LightSystem();
        c.PrintMessage(LightSystem.TrafficLight.Red);
        c.PrintMessage(LightSystem.TrafficLight.Yellow);
        c.PrintMessage(LightSystem.TrafficLight.Green);
    }
 }



  }