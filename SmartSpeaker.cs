using System;
using System.Collections.Generic;
using System.Text;

namespace umna_kusht
{
    internal class SmartSpeaker : SmartDevice, IControllable
    {
        private bool isOn;
        public SmartSpeaker(string Name, string Model) : base(Name, Model)
        {

        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine(Name + " е включен. Пуска музика или известия.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine(Name + " е изключен.");
        }

        public void Status()
        {
            Console.WriteLine(Name + ": " + (isOn ? "Включен" : "Изключен"));
        }
    }
}
