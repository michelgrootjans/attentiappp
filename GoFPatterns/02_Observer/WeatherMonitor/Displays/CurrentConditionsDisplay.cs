using System;

namespace WeatherMonitor.Displays
{
    internal class CurrentConditionsDisplay : IEventHandler<WeatherEventArgs>
    {
        public void UpdateDisplay(WeatherEventArgs e)
        {
            Console.WriteLine("Current weather:");
            Console.WriteLine("- {0}°C", e.Temperature);
            Console.WriteLine("- {0}% humidity", e.Humidity);
            Console.WriteLine("- {0} atm",  e.Pressure);
            Console.WriteLine();
        }

        public void Handle(WeatherEventArgs domainEvent)
        {
            UpdateDisplay(domainEvent);
        }
    }
}