using System;

namespace WeatherMonitor
{
    public class WeatherData
    {
        public void MeasurementsChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            NotifyObservers(temperature, humidity, pressure);
        }

        private void NotifyObservers(double temperature, double humidity, double pressure)
        {
            if (OnDataChanged != null)
                OnDataChanged(new WeatherEventArgs(temperature, humidity, pressure));
            EventAggregator.Raise(new WeatherEventArgs(temperature, humidity, pressure));
        }

        //simulate getting data from real instruments
        private double GetPressure()
        {
            return 1.05;
        }

        private double GetHumidity()
        {
            return 0.45;
        }

        private double GetTemperature()
        {
            return 14.6;
        }

        public event Action<WeatherEventArgs> OnDataChanged;
    }

    public class WeatherEventArgs : IDomainEvent
    {
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherEventArgs(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}