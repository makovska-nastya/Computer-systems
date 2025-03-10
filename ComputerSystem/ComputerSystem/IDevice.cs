using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    public interface IDevice
    {
        string Name { get; }
        string Type { get; }
        string GetDeviceInfo();
    }
    public delegate void DeviceEventHandler(string message);
}
