namespace Temperature_Change_Event_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Display display = new Display();
            display.Subscribe(thermostat);
            thermostat.SetTemperature(1);
            thermostat.SetTemperature(1);

        }
    }
}