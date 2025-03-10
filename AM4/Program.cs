/*Hanson Robotics Humanoid Robot AI:
Scenario: Hanson Robotics’ humanoid robots continuously learn from interactions and store
behavioral models in their AI core. However, this learning process should only be shared
with future humanoid models while preventing any unauthorized modifications. Implement
a protected method in a HumanoidAI class that allows robot subclasses to inherit learning
algorithms while preventing external alterations.
Challenge: Ensure that external entities cannot modify or directly access learned experiences
 while allowing different humanoid models to evolve and improve over time.
 */
 using System;
 namespace Test{
    //Base Class
    public class HumanoidAI{
        protected void HansonRobot(){
            Console.WriteLine("Learn from interactions and store behavioral model in their AI core");
        }
    }
    //Derived Class
    public class SophiaAI:HumanoidAI{
        public void AutoProcess(){
            Console.WriteLine("Continuously Upgrade data and auto Process and analyze them ");
            HansonRobot();
        }
    }
    //External Class
    public class UnAuthorizedAccess{
        public void TryAccess(){
            Console.WriteLine("Hacker will not able to access or modify the data");
        }
    }
    public class Myclass{
        public static void Main(){
            SophiaAI sophia=new SophiaAI();
            sophia.AutoProcess();

            UnAuthorizedAccess access=new UnAuthorizedAccess();
            access.TryAccess();

        } 
    }
 }