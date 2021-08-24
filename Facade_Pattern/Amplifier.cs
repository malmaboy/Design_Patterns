using System;

namespace Facade_Pattern
{
    // Class Exemple
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier On");
        }

        public void SetStreamingPlayer(string player)
        {
            Console.WriteLine("Amplifier setting steaming player to streaming player");
        }

        public void SetVolume(int volumeNumber)
        {
            Console.WriteLine($"Amplifier setting volume to {volumeNumber.ToString()}");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier Off");
        }
    }
}