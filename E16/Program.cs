/* Hanson Robotics Humanoid Robot Emotion Recognition:
Scenario: Humanoid robots by Hanson Robotics recognize and express different emotions
(Neutral, Happy, Sad, Angry, Surprised).
Problem Statement:
●	Define an enum EmotionState to represent different emotional states of the humanoid robot.
●	Create a class HumanoidRobot with methods DetectEmotion() (simulated by random selection) 
    and ExpressEmotion(EmotionState emotion).
●	Simulate an interactive program where a user inputs a situation (e.g., “You won an award!”),
    and the robot responds with an appropriate emotion.
 */
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
    public void ExpressEmotion(EmotionState emotion){
      switch(emotion){
        case EmotionState.Neutral:
        Console.WriteLine("The Robot is in Neutral state");
        break;
        case EmotionState.Happy:
        Console.WriteLine("The Robot is in Happy State");
        break;
        case EmotionState.Sad:
        Console.WriteLine("The Robot is feeling sad");
        break;
        case EmotionState.Angry:
        Console.WriteLine("The Robot is in angry state");
        break;
        case EmotionState.Surprised:
        Console.WriteLine("The Robot is in Surprised State");
        break;
      }
    }
   }

 class Myclass{
    public static void Main(){
        HumanoidRobot c=new HumanoidRobot();
        c.ExpressEmotion(HumanoidRobot.EmotionState.Neutral);
        c.ExpressEmotion(HumanoidRobot.EmotionState.Happy);
        c.ExpressEmotion(HumanoidRobot.EmotionState.Sad);
        c.ExpressEmotion(HumanoidRobot.EmotionState.Angry);
        c.ExpressEmotion(HumanoidRobot.EmotionState.Surprised);
    }
 }
 }