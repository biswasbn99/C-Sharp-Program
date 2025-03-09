/* Self-Guided Missile Targeting System:
Scenario: A self-guided missile system can target different types of threats 
(None, Aircraft, Tank, Infantry, Bunker, Ship).
Problem Statement:
●	Define an enum TargetType to represent various military targets.
●	Implement a class Missile with a method LockOnTarget(int target).
●	Simulate a missile launch system where a user selects a target, gives
    an input, and displays a message,and the system locks onto it before launching.
●   Display all of the messages and display all the targets.  */

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
        //Print a target of message based on targe
        public void LockOnTarget(int target){
            switch(target){
                case 1:
                Console.WriteLine("No Target locked !! ");
                break;
                case 2:
                Console.WriteLine("Missile locked on an Aircraft.");
                break;
                case 3:
                Console.WriteLine("Missile locked on a Tank.");
                break;
                case 4:
                Console.WriteLine("Missile locked on Infantry .");
                break;
                case 5:
                Console.WriteLine("Missile locked on a Bunker.");
                break;
                case 6:
                Console.WriteLine("Missile locked on a Ship.");
                break;
            }
        }

        //Print all message
        public void DisplayAllMessage(){
             Console.WriteLine("No Target locked !! ");
              Console.WriteLine("Missile locked on an Aircraft.");
              Console.WriteLine("Missile locked on a Tank.");
              Console.WriteLine("Missile locked on Infantry .");
               Console.WriteLine("Missile locked on a Bunker.");
                  Console.WriteLine("Missile locked on a Ship.");
        }
        //display all the targer
        public void DisplaysAll(){
            foreach(TargetType type in Enum.GetValues(typeof(TargetType))){
                Console.WriteLine(type);
            }
        }
    } 
    public class Myclass{
        public static void Main(){
            Missile c=new Missile();
        //Print a target of message based on targe
        Console.WriteLine("Enter a number between 1 to 6 :");
        int targe=Convert.ToInt32(Console.ReadLine());
        c.LockOnTarget(targe);
        Console.WriteLine();

           //Print all message
           Console.WriteLine("For Printing all messages of targed missile, press Enter Key !!");
           Console.ReadLine();
           c.DisplayAllMessage();
           Console.WriteLine();

           //display all the targer
           Console.WriteLine("For Printing all targed , press Enter Key !!");
           Console.ReadLine();
           c.DisplaysAll();
           Console.WriteLine();
            
        }
    }


 }