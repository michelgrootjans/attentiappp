using System;

namespace WeatherMonitor.Displays
{
    public class CurrentConditionsDisplay
    {
        public void UpdateDisplay(double temperature, double humidity, double pressure)
        {
            Console.WriteLine("Current weather:");
            Console.WriteLine("- {0}°C", temperature);
            Console.WriteLine("- {0}% humidity", humidity);
            Console.WriteLine("- {0} atm",  pressure);
            Console.WriteLine();
        }
    }
}