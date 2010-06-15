using System;

namespace WeatherMonitor.Displays
{
    internal class CurrentConditionsDisplay
    {
        public void Update(double temperature, double humidity, double pressure)
        {
            Console.WriteLine("Current weather:");
            Console.WriteLine("- {0}°C", temperature);
            Console.WriteLine("- {0}% humidity", humidity);
            Console.WriteLine("- {0} atm",  pressure);
            Console.WriteLine();
        }
    }
}