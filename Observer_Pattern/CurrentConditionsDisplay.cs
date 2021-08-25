using System;

namespace Observer_Pattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData _weatherData)
        {
            weatherData = _weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float _temperature, float _humidity,
            float _pressure)
        {
            temperature = _temperature;
            humidity = _humidity;
            
            Display();
            
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: Temperature -> {temperature} " +
                              $"Humidity -> {humidity}");
        }
    }
}