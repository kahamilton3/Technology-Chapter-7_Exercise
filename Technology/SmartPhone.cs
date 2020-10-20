using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public const string SubType = "SmartPhone";
        public string Manufacturer { get; set; }
        public bool Updates { get; set; } = false;

        public SmartPhone(string manufacturer, string deviceName, string processor, double ram) : base(deviceName, processor, ram)
        {
            Manufacturer = manufacturer;
        }

        public string CheckForUpdates()
        {
            if (!Updates)
            {
                return "No Updates Available";
            }
            else
            {
                return "Update Available";
            }
        }
    }
}
