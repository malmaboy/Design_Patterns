namespace Facade_Pattern
{
    public class HomeTheaterFacade
    {
        private Amplifier amp;
        private Lights lights;
        private Popper popper;
        public HomeTheaterFacade(Amplifier _amplifier, Lights _lights, Popper _popper)
        {
            amp = _amplifier;
            lights = _lights;
            popper = _popper;
        }

        public void WatchMovie(string movieName)
        {
            popper.On();
            popper.Pop();
            amp.On();
            amp.SetVolume(10);
            amp.SetSurroundSound();
            lights.On();
            lights.LightsDim(4);
        }

        public void EndMovie()
        {
            popper.Off();
            amp.Off();
            lights.LightsDim(70);
        }
    }
}