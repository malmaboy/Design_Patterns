using System;

namespace Facade_Pattern
{
    public class Popper
    {
        public void On()
        {
            Console.WriteLine("PopCorn Popper ON");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper popping popcorn!");
        }

        public void Off()
        {
            Console.WriteLine("Popper OFF");
        }
    }
}