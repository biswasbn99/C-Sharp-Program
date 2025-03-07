/* SpaceX Rocket Stages Management:
Scenario: SpaceX rockets have multiple stages, each serving a different purpose during a launch.
 You need to create an enumeration that represents different rocket stages (PreLaunch, Liftoff,
  StageSeparation, OrbitInsertion, Reentry, Landing).
  Problem Statement:
●	Define an enum RocketStage representing the different stages of a rocket launch.
●	Write a Rocket class that has a method AdvanceStage() to transition to the next stage.
●   When user take an input 1 to 6 ,print a stage based on number. 
●	Implement a program that simulates a SpaceX rocket launch by advancing through all stages 
    and printing the current stage.
●   Print all Rocket Stage
 */

 using System;
namespace Test{
public class Rocket{
    public enum RocketStage{
        PreLaunch=1,
        Liftoff,
        StageSeparation,
        OrbitInsertion,
        Reentry,
        Landing
    }
 //print a message according to user inpu based on stage
    public void AdvanceStage(int d){
        switch(d){
            case 1:
            Console.WriteLine("Preparing for Launch");
            break;
            case 2:
            Console.WriteLine("LiftOff !!Rocket is Ascending");
            break;
            case 3:
            Console.WriteLine("Stage Separation successful.");
            break;
            case 4:
            Console.WriteLine("Rocket has reached orbit");
            break;
            case 5:
            Console.WriteLine("Reentering Earth's Atmosphere.");
            break;
            case 6:
            Console.WriteLine("Rocket has landed successfully.");
            break;
        }

    }
   //print all message 
   public void DisplayAllMessage(){
    
            Console.WriteLine("Preparing for Launch");
            Console.WriteLine("LiftOff !!Rocket is Ascending");
            Console.WriteLine("Stage Separation successful.");
             Console.WriteLine("Rocket has reached orbit");
             Console.WriteLine("Reentering Earth's Atmosphere.");
             Console.WriteLine("Rocket has landed successfully.");
   }
   // Print all Rocket Stage
   public void DisplaysAll(){
    foreach (RocketStage stage in Enum.GetValues(typeof(RocketStage)))
    {
        Console.WriteLine(stage);
    }
   }
   
   }




class Myclass{
    public static void Main(){
        Rocket c=new Rocket();
        
        //print a message according to user inpu based on stage
        Console.WriteLine("Enter a number between 1 to 6 :");
        int d=Convert.ToInt32(Console.ReadLine());
        c.AdvanceStage(d);
        Console.WriteLine();

       //print all message 
        Console.WriteLine("For printing  all message,Press \"Enter key\" ");
        Console.ReadKey();
        c.DisplayAllMessage();
        Console.WriteLine();

        //Print all Rocket Stage
        Console.WriteLine("For printing  all Rocket Stages,Press \"Enter key\" ");
        Console.ReadKey();
        c.DisplaysAll();


       }
   }

}
