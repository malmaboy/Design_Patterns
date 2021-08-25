using System.Collections.Generic;

namespace Observer_Pattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        private float temperature;

        private float humidity;

        private float pressure;
        
        
        // Constructor
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature,humidity,pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float _temperature, float _humidity,
            float _pressure)
        {
            pressure = _pressure;
            temperature = _temperature;
            humidity = _humidity;
            
            MeasurementsChanged();
        }
    }
}