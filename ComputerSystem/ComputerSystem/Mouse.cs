using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ComputerSystem
    {
    public class Mouse : Device, IPeripheral
    {
        public string ConnectionType { get; set; }
        public int DPI { get; set; }

        public Mouse(string name, string connectionType, int dpi)
            : base(name, "Mouse")
        {
            ConnectionType = connectionType;
            DPI = dpi;
        }

        public override string GetDeviceInfo()
        {
            return $"{Name},{Type},{ConnectionType},{DPI}";
        }
        public event DeviceEventHandler OnDeviceConnected;
        public void Connect()
        {
            Console.WriteLine($"{Name} (Mouse) is connected.");
            OnDeviceConnected?.Invoke($"{Name} (Mouse) has been connected.");
        }
    }

}



