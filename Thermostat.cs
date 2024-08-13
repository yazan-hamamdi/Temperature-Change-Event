
namespace Temperature_Change_Event_Example
{
    public class Thermostat
    {
        public event EventHandler<TemperatureChangeEventArgs> ThermostatChanged; //EventHandler<T> is a built in delegate in C#

        public double OldTemperature;
        public double CurrentTemperature;

        public void SetTemperature (Double newTemperature)
        {
            if(newTemperature != CurrentTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = newTemperature;
                OnTemperature(OldTemperature, CurrentTemperature);
            }
        }
        private void OnTemperature(double oldTemperature, double ourrentTemperature)
        {
            OnTemperature(new TemperatureChangeEventArgs(oldTemperature, ourrentTemperature));//raising the event
        }
        //is a common pattern in C# to allow derived classes to override the event invocation logic if needed.
        //Protected: The method is accessible within the class it’s declared in and by derived classes.
        //Virtual: The method can be overridden by a derived class to provide a different implementation.
        //The main reason for making the event-raising method virtual is to
        // allow derived classes to modify or extend the behavior when the event is raised.
        protected virtual void OnTemperature(TemperatureChangeEventArgs e )
        {
            ThermostatChanged?.Invoke(this,e);
        }
    }
}
