using WeatherMonitor.Displays;

namespace WeatherMonitor
{
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