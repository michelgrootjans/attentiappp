using System;

namespace WeatherMonitor.Displays
{
    internal class ForecastingDisplay
    {
        public void Update(double temperature, double humidity, double pressure)
        {
            PredictFuture(temperature, humidity, pressure);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine("Weather forecast:");
            Console.WriteLine("- {0} with temperatures between {1}°C and {2}°C", "Cloudy", 8, 10);
        }

        private void PredictFuture(double temperature, double humidity, double pressure)
        {
            //To be implemented
        }
    }
}