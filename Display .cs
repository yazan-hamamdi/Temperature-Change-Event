

namespace Temperature_Change_Event_Example
{
    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.ThermostatChanged += Thermostat_ThermostatChanged;
        }
        public void UnSubscribe(Thermostat thermostat)
        {
            thermostat.ThermostatChanged -= Thermostat_ThermostatChanged;
        }

        private void Thermostat_ThermostatChanged(object? sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine("\n\nTemperature changed:");
            Console.WriteLine($"Temperature changed from {e.OldTemperature}°C");
            Console.WriteLine($"Temperature changed to {e.NewTemperature}°C");
            Console.WriteLine($"Temperature Difference to {e.Difference}°C");
        }
    }
}
