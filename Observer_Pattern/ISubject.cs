namespace Observer_Pattern
{
    public interface ISubject 
    {
        // both of these methods take an Observer as an argument
        //The observer to be registered or removed
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        // This method is called to notify all observers
        // when the subject's state has changed
        public void NotifyObservers();
    }
}