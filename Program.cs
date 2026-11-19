namespace umna_kusht
{
    interface IControllable
    {
        void TurnOn();
        void TurnOff();
        void Status();
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            SmartLight light = new SmartLight("Умна светлина", "Philips Hue");
            SmartThermostat thermostat = new SmartThermostat("Термостат", "Google Nest");
            SmartSpeaker speaker = new SmartSpeaker("Умен говорител", "Amazon Echo");

            
            List<IControllable> devices = new List<IControllable>
        {
            light,
            thermostat,
            speaker
        };

            
            int hour = DateTime.Now.Hour;

            Console.WriteLine("Текущ час: " + hour);
            Console.WriteLine("\nАвтоматично управление на умната къща:");

            
            if ((hour >= 6 && hour < 10) || (hour >= 18 && hour < 23))
            {
                light.TurnOn();
                speaker.TurnOn();
            }
            else
            {
                light.TurnOff();
                speaker.TurnOff();
            }

            
            thermostat.TurnOn();
            thermostat.SetTemperature(hour);

            
            Console.WriteLine("\nСтатус на всички устройства:");

            foreach (IControllable device in devices)
            {
                device.Status();
            }
        }
    }
}
