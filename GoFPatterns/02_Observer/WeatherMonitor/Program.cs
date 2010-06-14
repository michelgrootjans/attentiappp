using System;

namespace WeatherMonitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            weatherData.MeasurementsChanged();
            Console.ReadLine();
        }
    }
}