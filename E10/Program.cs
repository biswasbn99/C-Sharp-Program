/* SpaceX Rocket Stages Management:
Scenario: SpaceX rockets have multiple stages, each serving a different purpose during a launch.
 You need to create an enumeration that represents different rocket stages (PreLaunch, Liftoff,
  StageSeparation, OrbitInsertion, Reentry, Landing).
  Problem Statement:
●	Define an enum RocketStage representing the different stages of a rocket launch.
●	Write a Rocket class that has a method AdvanceStage() to transition to the next stage.
●	Implement a program that simulates a SpaceX rocket launch by advancing through all stages 
    and printing the current stage.
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

    public void AdvanceStage(RocketStage d){
        switch(d){
            case RocketStage.PreLaunch:
            Console.WriteLine("Preparing for Launch");
            break;
            case RocketStage.Liftoff:
            Console.WriteLine("LiftOff !!Rocket is Ascending");
            break;
            case RocketStage.StageSeparation:
            Console.WriteLine("Stage Separation successful.");
            break;
            case RocketStage.OrbitInsertion:
            Console.WriteLine("Rocket has reached orbit");
            break;
            case RocketStage.Reentry:
            Console.WriteLine("Reentering Earth's Atmosphere.");
            break;
            case RocketStage.Landing:
            Console.WriteLine("Rocket has landed successfully.");
            break;
        }

    }

}

class Myclass{
    public static void Main(){
        Rocket c=new Rocket();
        c.AdvanceStage(Rocket.RocketStage.PreLaunch);
        c.AdvanceStage(Rocket.RocketStage.Liftoff);
        c.AdvanceStage(Rocket.RocketStage.StageSeparation);
        c.AdvanceStage(Rocket.RocketStage.OrbitInsertion);
        c.AdvanceStage(Rocket.RocketStage.Reentry);
        c.AdvanceStage(Rocket.RocketStage.Landing);
    }
}

}
