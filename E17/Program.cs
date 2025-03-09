/* Hanson Robotics Humanoid Robot Emotion Recognition:
Scenario: Humanoid robots by Hanson Robotics recognize and express different emotions
(Neutral, Happy, Sad, Angry, Surprised).
Problem Statement:
●	Define an enum EmotionState to represent different emotional states of the humanoid robot.
●	Create a class HumanoidRobot with methods ExpressEmotion(int emotion).
●	Simulate an interactive program where a user inputs and display the corresponding message of
    the emotion, and display all messages and display all emotion . */

using System;
 namespace Test{
   public class HumanoidRobot{
    public enum EmotionState{
        Neutral,
        Happy,
        Sad,
        Angry,
        Surprised
    }
    //Print a message based on user input
    public void ExpressEmotion(int emotion){
      switch(emotion){
        case 1:
        Console.WriteLine("The Robot is in Neutral state");
        break;
        case 2:
        Console.WriteLine("The Robot is in Happy State");
        break;
        case 3:
        Console.WriteLine("The Robot is feeling sad");
        break;
        case 4:
        Console.WriteLine("The Robot is in angry state");
        break;
        case 5:
        Console.WriteLine("The Robot is in Surprised State");
        break;
      }
    }
    
    
    //Print all of the message based on user
    public void DisplayAllMessage(){
     Console.WriteLine("The Robot is in Neutral state");
       Console.WriteLine("The Robot is in Happy State");
       Console.WriteLine("The Robot is feeling sad");
       Console.WriteLine("The Robot is in angry state");
       Console.WriteLine("The Robot is in Surprised State");
    }
       //Print all Robot's Emotion state
       public void DisplaysAll(){
        foreach(EmotionState state in Enum.GetValues(typeof(EmotionState))){
            Console.WriteLine(state);
        }
       }

   }

 class Myclass{
    public static void Main(){
        HumanoidRobot c=new HumanoidRobot();
         //Print all of the message based on user
          Console.WriteLine("Enter an input between 1 to 5 :");
         int emotion=Convert.ToInt32(Console.ReadLine());
        
         c.ExpressEmotion(emotion);
         Console.WriteLine();

         //Print all of the message based on user
         Console.WriteLine("For Printing all message ,press Enter key !!");
         Console.ReadKey();
         c.DisplayAllMessage();
         Console.WriteLine();

          //Print all Robot's Emotion state
          Console.WriteLine("For Printing all Emotion states ,press Enter key !!");
          Console.ReadKey();
         c.DisplaysAll();
      
    }
 }
 }
