/*. Tesla Self-Driving Car Autonomy Levels:
Scenario: Tesla’s self-driving system operates at different autonomy levels
 (Manual, AssistedDriving, Autonomous, EmergencyOverride).
Problem Statement:
●	Define an enum AutonomyLevel to represent different levels of Tesla’s self-driving system.
●	Implement a class TeslaCar with a method SetAutonomy(AutonomyLevel level).
●	Implement a driving simulation where the car dynamically changes autonomy levels based on
 road conditions (e.g., rain, highway, urban).
 */
 using System;
 namespace Test{
   public class TeslaCar{
         public enum AutonomyLevel{
            Manual,
            AssistedDriving,
            Autonomous,
            EmergencyOverride
         }

         public void SetAutonomy(AutonomyLevel d){
            switch(d){
                case AutonomyLevel.Manual:
                Console.WriteLine("Tesla is in manual driving mode.");
                break;
                case AutonomyLevel.AssistedDriving:
                Console.WriteLine("Tesla is in assisting driving mode.");
                break;
                case AutonomyLevel.Autonomous:
                Console.WriteLine("Tesla is in autonomous driving mode.");
                break;
                case AutonomyLevel.EmergencyOverride:
                Console.WriteLine("Tesla is in emergency overriding mode. ");
                break;
            }
         }
    }

    class Myclass{
        public static void Main(){
            TeslaCar c=new TeslaCar();
            c.SetAutonomy(TeslaCar.AutonomyLevel.Manual);
            c.SetAutonomy(TeslaCar.AutonomyLevel.AssistedDriving);
            c.SetAutonomy(TeslaCar.AutonomyLevel.Autonomous);
            c.SetAutonomy(TeslaCar.AutonomyLevel.EmergencyOverride);
        }
    }
 }