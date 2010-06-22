using System;

namespace WeatherMonitor.Displays
{
    internal class ForecastingDisplay
    {
        public void Update(WeatherEventArgs e)
        {
            PredictFuture(e.Temperature, e.Humidity, e.Pressure);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine("Weather forecast:");
            Console.WriteLine("- {0} with temperatures between {1}°C and {2}°C", "Cloudy", 8, 10);
            Console.WriteLine();
        }

        private void PredictFuture(double temperature, double humidity, double pressure)
        {
            //Not important for this demo
        }
    }
}