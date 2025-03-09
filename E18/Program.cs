/*Self-Guided Missile Targeting System:
Scenario: A self-guided missile system can target different types of threats 
(None, Aircraft, Tank, Infantry, Bunker, Ship).
Problem Statement:
●	Define an enum TargetType to represent various military targets.
●	Implement a class Missile with a method LockOnTarget(TargetType target).
●	Simulate a missile launch system where a user selects a target, and the system locks onto
 it before launching.
 */
 using System;
 namespace Test{
    public class Missile{
        public enum TargetType{
            None=1,
            Aircraft,
            Tank,
            Infantry,
            Bunker,
            Ship
        }
        public void LockOnTarget(TargetType target){
            switch(target){
                case TargetType.None:
                Console.WriteLine("No Target locked !! ");
                break;
                case TargetType.Aircraft:
                Console.WriteLine("Missile locked on an Aircraft.");
                break;
                case TargetType.Tank:
                Console.WriteLine("Missile locked on a Tank.");
                break;
                case TargetType.Infantry:
                Console.WriteLine("Missile locked on Infantry .");
                break;
                case TargetType.Bunker:
                Console.WriteLine("Missile locked on a Bunker.");
                break;
                case TargetType.Ship:
                Console.WriteLine("Missile locked on a Ship.");
                break;
            }
        }
    } 
    public class Myclass{
        public static void Main(){
            Missile c=new Missile();
            c.LockOnTarget(Missile.TargetType.None);
            c.LockOnTarget(Missile.TargetType.Aircraft);
            c.LockOnTarget(Missile.TargetType.Tank);
            c.LockOnTarget(Missile.TargetType.Infantry);
            c.LockOnTarget(Missile.TargetType.Bunker);
            c.LockOnTarget(Missile.TargetType.Ship);
        }
    }


 }