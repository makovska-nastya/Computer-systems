using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSystem
{
    public abstract class Device : IDevice
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        protected Device(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public abstract string GetDeviceInfo();
    }

}
