using System;

namespace Facade_Pattern
{
    class Program
    {
        private Amplifier amplifier = new Amplifier();
        private Lights lights = new Lights();
        private Popper popper = new Popper();

        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            
            program.Run();
        }

        private void Run()
        {
          
            
            HomeTheaterFacade homeTheaterFacade =
                new HomeTheaterFacade(amplifier, lights, popper);
            
            homeTheaterFacade.WatchMovie("SAW 3");
            homeTheaterFacade.EndMovie();
        }
    }
}
