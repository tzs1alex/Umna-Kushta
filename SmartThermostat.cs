using System;
using System.Collections.Generic;
using System.Text;

namespace umna_kusht
{
    internal class SmartThermostat : SmartDevice, IControllable
    {
        private bool isOn;
        public int Temperature { get; set; }
        public SmartThermostat(string Name, string Model) : base(Name, Model)
        {
            Temperature = 20;
        }
        public void SetTemperature(int hour)
        {
            if (hour >= 18 && hour < 23)
                Temperature = 24; 
            else if (hour >= 6 && hour < 18)
                Temperature = 21; 
            else
                Temperature = 18;

            Console.WriteLine("Настроена температура: " + Temperature + " градуса.");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine(Name + " е включен.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine(Name + " е изключен.");
        }

        public void Status()
        {
            Console.WriteLine(Name + ": " +
                (isOn ? "Включен" : "Изключен") + ", температура: " + Temperature + "°C");
        }
    }
}
