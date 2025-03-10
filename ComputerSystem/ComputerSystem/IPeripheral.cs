using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    public interface IPeripheral : IDevice
    {
        void Connect();

        event DeviceEventHandler OnDeviceConnected;
    }
}
