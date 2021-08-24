using System;

namespace Facade_Pattern
{
    public class Lights
    {
        public void On()
        {
            Console.WriteLine("Lights are on");
        }

        public void LightsDim(int percentage)
        {
            Console.WriteLine($"Theater ceiling light dimming to {percentage}%");
        }
    }
}