using System;
using System.IO;
using WeatherMonitor.Displays;

namespace WeatherMonitor
{
    public static class Program
    {
        public static void Main()
        {
            var display1 = new CurrentConditionsDisplay();
            var display2 = new StatisticsDisplay();
            var display3 = new ForecastingDisplay();

            EventAggregator.Register(display2);

            var weatherData = new WeatherData();

            var adapter = new CurrentDisplayAdapter(display1);
            weatherData.OnDataChanged += adapter.UpdateDisplay;

            display3 = null;

            weatherData.MeasurementsChanged();
            Console.ReadLine();
        }
    }

    public class CurrentDisplayAdapter
    {
        private readonly CurrentConditionsDisplay display;

        public CurrentDisplayAdapter(CurrentConditionsDisplay display)
        {
            this.display = display;
        }

        public void UpdateDisplay(WeatherEventArgs e)
        {
            display.UpdateDisplay(e.Temperature, e.Humidity, e.Pressure);
        }
    }
}