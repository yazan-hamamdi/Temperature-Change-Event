
namespace Temperature_Change_Event_Example
{
    public class TemperatureChangeEventArgs : EventArgs //custom event data class
    {
        public double NewTemperature { get;}
        public double OldTemperature { get; }
        public double Difference { get; }
        public TemperatureChangeEventArgs (double newTemperature , double oldTemperature)
        {
            this.NewTemperature = newTemperature;
            this.OldTemperature = oldTemperature;
            this.Difference = newTemperature - oldTemperature;
        }

    }
}
