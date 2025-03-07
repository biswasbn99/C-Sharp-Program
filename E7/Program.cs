/*Create an enumeration TrafficLight with values Red, Yellow, and Green. Write a C# program
 that  prompts the user to enter a number (1 to 3) and displays the corresponding light using 
 the enumeration & Display all light and prints different messages for each light 
 color and display all of the traffic light under the enumeration*/
 using System;
 namespace Test{
    public class LightSystem{
        public enum TrafficLight{
            Red=1,
            Yellow,
            Green
        }
        //print message corresponding light
        public void PrintMessage(int d){
            switch(d){
                case 1:
                Console.WriteLine("The light is \"Red \" ");
                break;
                case 2:
                Console.WriteLine("The light is \"Yellow\" ");
                break;
                case 3:
                Console.WriteLine("The light is \"Green\" ");
                break;
            }
        }
    
    //print All Message
    public void DisplayAllMessage(){
        Console.WriteLine("The light is \"Red\" ");
         Console.WriteLine("The light is \"Yellow\" ");
          Console.WriteLine("The light is \"Green\" ");
    }
   //print All Light
   public  void DisplayLight(){
    foreach(TrafficLight light in Enum.GetValues(typeof(TrafficLight))){
        Console.WriteLine(light);
    }
    
   }

 }
class Myclass{
public static void Main(){
    LightSystem c= new LightSystem();
    //print message corresponding light(press 1-3)
    Console.WriteLine("Enter a value within 1 to 3: ");
    int d=Convert.ToInt32(Console.ReadLine());
    c.PrintMessage(d);
  Console.WriteLine();

      //print All Message
      Console.WriteLine("Print all message ,press \'enter Key\' ");
        Console.ReadKey();
      c.DisplayAllMessage();
    Console.WriteLine();


      //print All Light
     Console.WriteLine("Print all Light ,press \'enter Key\' ");
     Console.ReadKey();
     c.DisplayLight();
}

 }
 }