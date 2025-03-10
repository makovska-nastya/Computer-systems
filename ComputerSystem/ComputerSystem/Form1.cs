using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ComputerSystem
{
    public partial class Form1 : MaterialForm
    {
        private SystemUnit systemUnit = new SystemUnit();

        public Form1()
        {
            InitializeComponent();

            // Налаштування MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.LightBlue200, TextShade.WHITE);

            LoadDevicesFromFile();
        }

        private void MaterialButtonAdd_Click(object sender, EventArgs e)
        {
            string name = MaterialTextBoxName.Text;
            string type = MaterialComboBoxType.SelectedItem.ToString();
            string param1 = MaterialTextBoxInfo.Text;
            string param2 = MaterialTextBoxExtra.Text;

            Device device = null;

            if (type == "Monitor")
            {
                device = new Monitor(name, param1, param2);
            }
            else if (type == "Mouse")
            {
                if (int.TryParse(param2, out int dpi))
                {
                    device = new Mouse(name, param1, dpi);
                }
                else
                {
                    MessageBox.Show("DPI must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (device != null)
            {
                systemUnit.AddDevice(device);
                MaterialListView1.Items.Add(new ListViewItem(new[] { name, type, param1, param2 }));
                systemUnit.SaveDevicesToFile();
            }
        }

        private void LoadDevicesFromFile()
        {
            systemUnit.LoadDevicesFromFile();
            MaterialListView1.Items.Clear();

            foreach (var device in systemUnit.Devices)
            {
                string[] deviceInfo = device.GetDeviceInfo().Split(',');
                MaterialListView1.Items.Add(new ListViewItem(deviceInfo));
            }
        }

        private void MaterialButtonRemove_Click(object sender, EventArgs e)
        {
            if (MaterialListView1.SelectedItems.Count > 0)
            {
                string deviceName = MaterialListView1.SelectedItems[0].Text;

                if (systemUnit.RemoveDevice(deviceName))
                {
                    MaterialListView1.Items.Remove(MaterialListView1.SelectedItems[0]);
                    systemUnit.SaveDevicesToFile();
                }
                else
                {
                    MessageBox.Show("Device not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a device to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MaterialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialListView1.SelectedItems.Count > 0)
            {
                string selectedDeviceName = MaterialListView1.SelectedItems[0].Text;
                Device selectedDevice = systemUnit.Devices.FirstOrDefault(d => d.Name == selectedDeviceName);

                if (selectedDevice != null)
                {
                    MaterialTextBoxName.Text = selectedDevice.Name;
                    MaterialComboBoxType.SelectedItem = selectedDevice.Type;

                    if (selectedDevice is Monitor monitor)
                    {
                        MaterialTextBoxInfo.Text = monitor.Resolution;
                        MaterialTextBoxExtra.Text = monitor.ScreenSize;
                    }
                    else if (selectedDevice is Mouse mouse)
                    {
                        MaterialTextBoxInfo.Text = mouse.ConnectionType;
                        MaterialTextBoxExtra.Text = mouse.DPI.ToString();
                    }
                }
            }
        }
    }
}
