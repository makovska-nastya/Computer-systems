using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    public class Monitor : Device, IPeripheral
    {
        public string Resolution { get; set; }
        public string ScreenSize { get; set; }

        public Monitor(string name, string resolution, string screenSize)
            : base(name, "Monitor")
        {
            Resolution = resolution;
            ScreenSize = screenSize;
        }

        public override string GetDeviceInfo()
        {
            return $"{Name},{Type},{Resolution},{ScreenSize}";
        }
        public event DeviceEventHandler OnDeviceConnected;
        public void Connect()
        {
            Console.WriteLine($"{Name} (Monitor) is connected.");
            OnDeviceConnected?.Invoke($"{Name} (Monitor) has been connected.");
        }
    }

}
