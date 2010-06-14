using System;

namespace WeatherMonitor.Displays
{
    internal class StatisticsDisplay
    {
        public void Update(double temperature, double humidity, double pressure)
        {
            AddToStatistics(DateTime.Now, temperature, humidity, pressure);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine("Weather statiscitcs:");
            Console.WriteLine("- Temperature: {0}°C min - {1}°C avg {2}°C max", 5.6, 12.5, 21.4);
        }

        private void AddToStatistics(DateTime timeStamp, double temperature, double humidity, double pressure)
        {
            //Not important for this demo
        }
    }
}