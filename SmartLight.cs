using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace umna_kusht
{
    internal class SmartLight: SmartDevice , IControllable
    {
        public SmartLight(string Name, string Model) : base(Name, Model)
        {
            
        }
        private bool isOn;
        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine(Name + " е включена.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine(Name + " е изключена.");
        }

        public void Status()
        {
            Console.WriteLine(Name + ": " + (isOn ? "Включена" : "Изключена"));
        }
    }
}
