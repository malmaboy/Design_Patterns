using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            
            program.Run();
        }

        private void Run()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay =
                new CurrentConditionsDisplay(weatherData);
            
            weatherData.SetMeasurements(30,65,30.4f);
            weatherData.SetMeasurements(24,75,29.4f);
            weatherData.SetMeasurements(22,95,29.2f);
        }
    }
}
