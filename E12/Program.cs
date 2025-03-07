/*  Neuralink Brain Implant Mode Switching:
Scenario: Neuralink implants operate in multiple modes (Idle, DataProcessing, NeuroStimulation,
 SleepMode). The implant's behavior depends on the input from neural signals.
Problem Statement:
●	Create an enum ImplantMode to represent different operating states of a Neuralink implant.
●	Implement a class NeuralinkDevice with a method SwitchMode(ImplantMode mode) that allows 
    changing modes based on external triggers.
●	Simulate a Neuralink device that cycles through different states based on user input.
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
    public void SwitchMode(ImplantMode mode){
        switch(mode){
            case ImplantMode.Idle:
            Console.WriteLine("Neuralink is in Idle mode.");
            break;
            case ImplantMode.DataProcessing:
            Console.WriteLine("Neuralink is processing the data.");
            break;
            case ImplantMode.NeuroStimulation:
            Console.WriteLine("Neuralink is in stimulation mode.");
            break;
            case ImplantMode.SleepMode:
            Console.WriteLine("Neuralink is in Sleeping Mode");
            break;
        }
    }



}
class Myclass{
    public static void Main(){
        NeuralinkDevice c=new NeuralinkDevice();
        c.SwitchMode(NeuralinkDevice.ImplantMode.Idle);
        c.SwitchMode(NeuralinkDevice.ImplantMode.DataProcessing);
        c.SwitchMode(NeuralinkDevice.ImplantMode.NeuroStimulation);
        c.SwitchMode(NeuralinkDevice.ImplantMode.SleepMode);
    }
}

}