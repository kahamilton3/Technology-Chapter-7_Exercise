using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public const string Type = "Computer";
        public string DeviceName { get; set; }
        public string Processor { get; set; }
        public double Ram { get; set; }

        public Computer(string deviceName, string processor, double ram) : base()
        {
            DeviceName = deviceName;
            Processor = processor;
            Ram = ram;
        }

        public void RenameThisDevice(string newName)
        {
            DeviceName = newName;
        }

        public void UpgradeRam(double additionalRam)
        {
            Ram += additionalRam;
        }
    }
}
