namespace Observer_Pattern
{
    public interface IObserver
    {
        // These are the states values the observers get from the ISubject when 
        // when a weather measurement changes 
        public void Update(float temperature, float humidity, float pressure);
    }
}