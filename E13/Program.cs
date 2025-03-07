/*  Neuralink Brain Implant Mode Switching:
Scenario: Neuralink implants operate in multiple modes (Idle, DataProcessing, NeuroStimulation,
 SleepMode). The implant's behavior depends on the input from neural signals.
Problem Statement:
●	Create an enum ImplantMode to represent different operating states of a Neuralink implant.
●	Implement a class NeuralinkDevice with a method that allows 
    changing modes based on user input(1 to 4 ).
●	print all message
●   Print all modes
*/
using System;

namespace Test{
    public class NeuralinkDevice{
        public enum ImplantMode{
            Idle=1,
            DataProcessing,
            NeuroStimulation,
            SleepMode

    }
    //changing modes based on user input(1 to 4 ).
    public void SwitchMode(int mode){
        switch(mode){
            case 1:
            Console.WriteLine("Neuralink is in Idle mode.");
            break;
            case 2:
            Console.WriteLine("Neuralink is processing the data.");
            break;
            case 3:
            Console.WriteLine("Neuralink is in stimulation mode.");
            break;
            case 4:
            Console.WriteLine("Neuralink is in Sleeping Mode");
            break;
        }
    }
   //print all message
   public void DisplayAllMessage(){
    Console.WriteLine("Neuralink is in Idle mode.");
    Console.WriteLine("Neuralink is processing the data.");
    Console.WriteLine("Neuralink is in stimulation mode.");
    Console.WriteLine("Neuralink is in Sleeping Mode");

   }
   //Print all modes
    public void DisplaysAll(){
        foreach(ImplantMode implant in Enum.GetValues(typeof(ImplantMode))){
            Console.WriteLine(implant);
        }
    }

}
class Myclass{
    public static void Main(){
        NeuralinkDevice c=new NeuralinkDevice();
        //changing modes based on user input(1 to 4 ).
        Console.WriteLine("Enter a number 1 to 4 :");
        int mode=Convert.ToInt32(Console.ReadLine());
        c.SwitchMode(mode);
        Console.WriteLine();

          //print all message
         Console.WriteLine("For Printing all message ,press \"Enter key\" ");
         Console.ReadKey();
         c.DisplayAllMessage();
         Console.WriteLine();

       //Print all modes 
       Console.WriteLine("For printing all modes , press \"Enter key \" ");   
       Console.ReadKey();
       c.DisplaysAll();
    }
}

}