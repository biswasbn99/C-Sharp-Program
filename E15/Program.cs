/*  Tesla Self-Driving Car Autonomy Levels:
Scenario: Tesla’s self-driving system operates at different autonomy levels
 (Manual, AssistedDriving, Autonomous, EmergencyOverride).
Problem Statement:
●	Define an enum AutonomyLevel to represent different levels of Tesla’s self-driving system.
●	Implement a class TeslaCar with a method SetAutonomy(int level) where use give an input and 
    car drive on respective mode.
●	display all of the message and display the different autonomy levels.
 */
 using System;
 namespace Test{
   public class TeslaCar{
         public enum AutonomyLevel{
            Manual=1,
            AssistedDriving,
            Autonomous,
            EmergencyOverride
         }
              //User give an input and display the corresponding mesage
         public void SetAutonomy(int level){
            switch(level){
                case 1:
                Console.WriteLine("Tesla is in manual driving mode.");
                break;
                case 2:
                Console.WriteLine("Tesla is in assisting driving mode.");
                break;
                case 3:
                Console.WriteLine("Tesla is in autonomous driving mode.");
                break;
                case 4:
                Console.WriteLine("Tesla is in emergency overriding mode. ");
                break;
            }
         }

         //Print all of the 
         public void DisplayAllMessage(){
            Console.WriteLine("Tesla is in manual driving mode.");
             Console.WriteLine("Tesla is in assisting driving mode.");
             Console.WriteLine("Tesla is in autonomous driving mode.");
                Console.WriteLine("Tesla is in emergency overriding mode. ");
         }
         //Print all autonomy level
         public void DisplaysAll(){
            foreach (AutonomyLevel levels in Enum.GetValues(typeof(AutonomyLevel))){
                Console.WriteLine(levels);
            }
            
         }
    }

    class Myclass{
        public static void Main(){
            TeslaCar c=new TeslaCar();

            //user iput
            Console.WriteLine("Take an input (between 1 to 4) from user:");
            int level=Convert.ToInt32(Console.ReadLine());
            c.SetAutonomy(level);
            Console.WriteLine();

            //Print all message
            Console.WriteLine("For printing all message ,press Enter key!! ");
            Console.ReadKey();
            c.DisplayAllMessage();
            Console.WriteLine();

            //Print autonomy level
            Console.WriteLine("For printing all autonomy levels ,press Enter key");
            Console.ReadKey();
            c.DisplaysAll();
            
        }
    }
 }