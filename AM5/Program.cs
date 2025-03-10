/* Self-Guided Missile System Security:
Scenario: A self-guided missile system employs a sophisticated lock-on algorithm to track 
and hit its target. This algorithm should not be modifiable by any external system to prevent
hacking or unauthorized modifications. Implement a private method in a MissileGuidance class
that ensures only internal methods of the same class can execute and modify the missile's 
lock-on algorithm.
Challenge: Ensure that unauthorized functions cannot access or modify the missile guidance 
logic while allowing controlled updates through secure internal mechanisms.
 */
 using System;
 namespace Test{
    //Base class
    public class MissileGuidance{
        private void AkashMissileSystem(){
         Console.WriteLine("The missile is used to lock on algorithm to track and hit its target");
        }
        public void AutoMissileSytem()//private level don't have any derived class 
        {
        Console.WriteLine("Auto track the object and fixed the target!!");
        AkashMissileSystem();
    }
    }
    public class UnAuthorizedAccess{
        public void TryAccess(){
            Console.WriteLine("Hackers will not able to access or modify the system");
        }
    }
    public class Myclass{
        public static void Main(){
            MissileGuidance missile=new MissileGuidance();
            missile.AutoMissileSytem();

            UnAuthorizedAccess access=new UnAuthorizedAccess();
            access.TryAccess();
        }
    }
}

 