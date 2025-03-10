using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComputerSystem
{

    public class SystemUnit
    {
        public List<Device> Devices { get; private set; } = new List<Device>();

        private string filePath = "devices.txt";

        public void AddDevice(Device device)
        {
            if (device != null)
            {
                Devices.Add(device);
            }
        }

        public void SaveDevicesToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Device device in Devices)
                {
                    writer.WriteLine(device.GetDeviceInfo());
                }
            }
        }

        public void LoadDevicesFromFile()
        {
            Devices.Clear();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        if (parts[1] == "Monitor")
                        {
                            Devices.Add(new Monitor(parts[0], parts[2], parts[3]));
                        }
                        else if (parts[1] == "Mouse")
                        {
                            Devices.Add(new Mouse(parts[0], parts[2], int.Parse(parts[3])));
                        }
                    }
                }
            }
        }
        public Device this[int index]
        {
            get
            {
                if (index >= 0 && index < Devices.Count)
                    return Devices[index];
                throw new IndexOutOfRangeException("Invalid device index.");
            }
        }
        public bool RemoveDevice(string name)
        {
            var device = Devices.FirstOrDefault(d => d.Name == name);
            if (device != null)
            {
                Devices.Remove(device);
                return true;
            }
            return false;
        }
    }

}
