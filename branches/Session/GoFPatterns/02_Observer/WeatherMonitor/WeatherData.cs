using WeatherMonitor.Displays;

namespace WeatherMonitor
{
    public class WeatherData
    {
        private CurrentConditionsDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastingDisplay forecastingDisplay;

        public WeatherData()
        {
            currentConditionsDisplay = new CurrentConditionsDisplay();
            statisticsDisplay  = new StatisticsDisplay();
            forecastingDisplay = new ForecastingDisplay();
        }

        public void MeasurementsChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            currentConditionsDisplay.Update(temperature, humidity, pressure);
            statisticsDisplay.Update(temperature, humidity, pressure);
            forecastingDisplay.Update(temperature, humidity, pressure);
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
    }
}