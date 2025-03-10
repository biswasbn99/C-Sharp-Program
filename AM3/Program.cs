/*Tesla Self-Driving Car Navigation:
Scenario: Tesla’s self-driving software needs to retrieve real-time traffic data.
 However, this data should only be accessible within Tesla’s software ecosystem. 
 Implement an internal method in a NavigationSystem class that allows only Tesla’s 
 internal software components to process and analyze real-time traffic conditions.
 Challenge: Ensure that the navigation data cannot be accessed or modified by external
 applications or third-party software.
 */
 using System;
 namespace Test{
     
     //Base Class
     public class NavigationSystem{
        internal void TeslaSelfEcosystem(){
            Console.WriteLine("Analyze real-time traffic conditions");
        }
     }
     //Derived Class
     public class AutoProcess:NavigationSystem{
       public void DataAutoProcess(){
        Console.WriteLine("Track the traffic Conditions Automatically");
        TeslaSelfEcosystem();
       }
     }
public class UnAuthorizedAccess{
    public void TryAccess(){
        Console.WriteLine("Hackers will not able to enter the system ??");
    }
}
public class Myclass{
    public static void Main(){
        AutoProcess process=new AutoProcess();
        process.DataAutoProcess();
        UnAuthorizedAccess access=new UnAuthorizedAccess();
        access.TryAccess();
    }
}

 }