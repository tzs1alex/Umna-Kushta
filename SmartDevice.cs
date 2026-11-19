using System;
using System.Collections.Generic;
using System.Text;

namespace umna_kusht
{
    internal class SmartDevice
    {
         public string Name {  get; set; }
        public string Model { get; set; }

        public SmartDevice(string Name, string Model)
        {
            this.Name = Name;
            this.Model = Model;
        }
    }
}
