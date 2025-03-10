/* SpaceX Rocket Control System:
Scenario: SpaceX rockets have an emergency shutdown protocol that must be accessible 
only within the SpaceX software ecosystem and by specific mission-critical modules. Implement 
a protected internal method in a RocketControlSystem class that allows derived classes within
 the same assembly to trigger an emergency shutdown while preventing external access.
Challenge: Ensure that unauthorized external classes cannot trigger a shutdown while still
 allowing future derived rocket models to inherit and execute the function.
 */
 using System;
 namespace Test{
    //Base class
    public class RocketControlSystem{
        protected internal void EmergencyShutdown(){
           Console.WriteLine("Emergency Shutdown initiated Due to system failure or other reasons!!");

        }

    }
    //Derived class
    public class FalconRocket:RocketControlSystem
    {
        public void TriggerEmergencyShutdown(){
            Console.WriteLine("Falcon Rocket detects the system is Error!!");
            EmergencyShutdown();
        }
    }

  //Extrenal class
  public class UnAuthorizedAccess{
    public void TryShutDown(){
        RocketControlSystem c=new RocketControlSystem();//this is not needed
        //c.EmergencyShutdown();//it is error due to internal protection
        Console.WriteLine("Hackers will not able to enter the system??");
    }
  }
  class Myclass{
    public static void Main(){
        FalconRocket falcon=new FalconRocket();
        falcon.TriggerEmergencyShutdown();

        UnAuthorizedAccess access=new UnAuthorizedAccess();
        access.TryShutDown();
    }
  }



 }