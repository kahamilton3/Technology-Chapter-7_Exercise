using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public const string SubType = "Laptop";
        public string Manufacturer { get; set; }
        public bool Updates { get; set; } = false;

        public Laptop(string manufacturer, string deviceName, string processor, double ram) : base(deviceName, processor, ram)
        {
            Manufacturer = manufacturer;
        }

        public string CheckForUpdates()
        {
            if (!Updates)
            {
                return "No Updates Available";
            } else
            {
                return "Update Available";
            }
        }
    }
}
