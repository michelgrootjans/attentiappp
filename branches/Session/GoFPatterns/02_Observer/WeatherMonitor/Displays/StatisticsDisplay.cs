using System;

namespace WeatherMonitor.Displays
{
    internal class StatisticsDisplay
    {
        public void Update(WeatherEventArgs e)
        {
            AddToStatistics(DateTime.Now, e.Temperature, e.Humidity, e.Pressure);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine("Weather statistics:");
            Console.WriteLine("- Temperature: {0}°C min - {1}°C avg - {2}°C max", 5.6, 12.5, 21.4);
            Console.WriteLine();
        }

        private void AddToStatistics(DateTime timeStamp, double temperature, double humidity, double pressure)
        {
            //Not important for this demo
        }
    }
}