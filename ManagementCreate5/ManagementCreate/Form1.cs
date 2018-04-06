using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ManagementCreate
{
    /* --- INITIALIZATION: --- */

    public partial class Form1 : Form
    {
        List<Device> devicelist = new List<Device>();
        List<Product> productlist = new List<Product>();
        string devicePath = "C:\\temp\\Devices\\Devicelist.txt";
        string productPath = "C:\\temp\\Products\\Productlist.txt";

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp");
            }
            if (!Directory.Exists("C:\\temp\\Devices"))
            {
                Directory.CreateDirectory("C:\\temp\\Devices");
            }
            if (!Directory.Exists("C:\\temp\\Products"))
            {
                Directory.CreateDirectory("C:\\temp\\Products");
            }
            if (File.Exists(@devicePath))
            {
                string json = File.ReadAllText(@devicePath);
                List<Device> oldDevList = JsonConvert.DeserializeObject<List<Device>>(json);
                for (int i = 0; i < oldDevList.Count; i++)
                {
                    devicelist.Add(oldDevList.ElementAt(i));
                }
            }
            UpdateList();
            UpdateDevList();
            UpdateProList();
        }

    /* --- BUTTON FUNCTIONS: --- */

        /* --- Create device --- */

        private void btnCreateDev_Click(object sender, EventArgs e)
        {
            string devAddress = tbDevAddress.Text + ", " + tbDevPostCode.Text;
            if (!File.Exists(@devicePath))
            {
                var file = File.Create(@devicePath);
                file.Close();
            }
            Device device = new Device();
            devicelist.Add(device.CreateDevice(tbDevName.Text, tbDevIp.Text, devAddress));
            string deviceString = JsonConvert.SerializeObject(devicelist);
            File.WriteAllText(@devicePath, deviceString);
            UpdateList();
            tbDevName.Text = tbDevIp.Text = tbDevAddress.Text = tbDevPostCode.Text = "";
            UpdateDevList();
            lblMsg.Text = "A new device was succesfully added.";
        }

        public void createDevice()
        {
        } 

        /* --- Create product --- */

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (File.Exists(@productPath))
            {
                string temp = File.ReadAllText(productPath);
                productlist = JsonConvert.DeserializeObject<List<Product>>(temp);
            }
            Product product = new Product();
            List<Device> deviceRoute = new List<Device>();
            if (File.Exists(devicePath))
            {
                string temp2 = File.ReadAllText(devicePath);
                devicelist = JsonConvert.DeserializeObject<List<Device>>(temp2);
                for (int i = 0; i < lbRoute.Items.Count; i++)
                {
                    for (int j = 0; j < devicelist.Count; j++)
                    {
                        if (lbRoute.GetItemText(lbRoute.Items[i]) == devicelist[j].Name)
                        {
                            deviceRoute.Add(devicelist[j]);
                        }
                    }
                }
            }
            product = product.CreateProduct(tbProductName.Text, deviceRoute);
            productlist.Add(product);
            string productString = JsonConvert.SerializeObject(productlist);
            File.WriteAllText(@productPath, productString);
            tbProductName.Text = "";
            cbRoute.ResetText();
            lbRoute.Items.Clear();
            UpdateProList();
            lblMsg.Text = "Product \"" + product.Name + "\" was succesfully created.";
        }

        /* --- Move-button --- */

        private void btnMove_Click(object sender, EventArgs e)
        {
            lbRoute.Items.Add(cbRoute.SelectedItem.ToString());
        }

        /* --- Delete-button --- */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbRoute.Items.Remove(lbRoute.SelectedItem);
        }

    /* --- OTHER FUNCTIONS: --- */

        public void FetchList(string path, string type)
        {
            if (File.Exists(path))
            {
                string temp = File.ReadAllText(path);
                switch (type)
                {
                    case "Device":
                        break;
                    default:
                        break;
                }
            }
        }
      
        /* --- Update --- */

        public void UpdateList()
        {
            if (File.Exists(@"C:\\temp\\Devices\\Devicelist.txt"))
            {
                string temp = File.ReadAllText("C:\\temp\\Devices\\Devicelist.txt");
                List<Device> NewDevList = JsonConvert.DeserializeObject<List<Device>>(temp);
                cbRoute.Items.Clear();
                for (int i = 0; i < NewDevList.Count; i++)
                {
                    cbRoute.Items.Add(NewDevList.ElementAt(i).Name);
                }               
            }
        }

        public void UpdateDevList()
        {
            if (File.Exists(@"C:\\temp\\Devices\\Devicelist.txt"))
            {
                string temp = File.ReadAllText("C:\\temp\\Devices\\Devicelist.txt");
                List<Device> NewDevList = JsonConvert.DeserializeObject<List<Device>>(temp);
                lbDevs.Items.Clear();
                for (int i = 0; i < NewDevList.Count; i++)
                {
                    lbDevs.Items.Add(NewDevList.ElementAt(i).Name);
                }
            }
        }

        public void UpdateProList()
        {
            if (File.Exists(@"C:\\temp\\Products\\Productlist.txt"))
            {
                string temp = File.ReadAllText("C:\\temp\\Products\\Productlist.txt");
                List<Product> NewProList = JsonConvert.DeserializeObject<List<Product>>(temp);
                lbPros.Items.Clear();
                for (int i = 0; i < NewProList.Count; i++)
                {
                    lbPros.Items.Add(NewProList.ElementAt(i).Name);
                }
            }
        }

        /* --- Delete --- */

        public void DeleteDev()
        {
            if (File.Exists(devicePath))
            {
                string temp = File.ReadAllText(devicePath);
                List<Device> newDevList = JsonConvert.DeserializeObject<List<Device>>(temp);
                for (int i = 0; i < newDevList.Count; i++)
                {
                    if (lbDevs.GetSelected(i))
                    {
                        if (MessageBox.Show("Are you sure you want to delete " + lbDevs.GetItemText(lbDevs.SelectedItem) + "?", "Delete Device", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            newDevList.RemoveAt(i);
                        }
                    }
                }
                string newDevString = JsonConvert.SerializeObject(newDevList);
                devicelist = newDevList;
                File.WriteAllText(@devicePath, newDevString);
                UpdateDevList();
                UpdateList();
            }
        }

        public void DeletePro()
        {
            if (File.Exists(productPath))
            {
                string temp = File.ReadAllText(productPath);
                List<Product> newProList = JsonConvert.DeserializeObject<List<Product>>(temp);
                for (int i = 0; i < newProList.Count; i++)
                {
                    if (lbPros.GetSelected(i))
                    {
                        if (MessageBox.Show("Are you sure you want to delete " + lbPros.GetItemText(lbPros.SelectedItem) + "?", "Delete Product", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            newProList.RemoveAt(i);
                        }
                    }
                }
                string newProString = JsonConvert.SerializeObject(newProList);
                productlist = newProList;
                File.WriteAllText(@productPath, newProString);
                UpdateProList();
            }
        }

        private void lbRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                lbRoute.Items.Remove(lbRoute.SelectedItem);
            }
        }

        private void btnDeleteDev_Click(object sender, EventArgs e)
        {
            if (lbDevs.SelectedItem != null)
            {
                DeleteDev();
            }
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if (lbPros.SelectedItem != null)
            {
                DeletePro();
            }
        }

        private void lbDevs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                if (lbDevs.SelectedItem != null)
                {
                    DeleteDev();
                }
            }
        }

        private void lbPros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                if (lbPros.SelectedItem != null)
                {
                    DeletePro();
                }
            }
        }

        /* --- Edit --- */

        private void btnEditDev_Click(object sender, EventArgs e)
        {
            if(lbDevs.SelectedItem != null)
            {
                FormDevEdit formDevEdit = new FormDevEdit(lbDevs.GetItemText(lbDevs.SelectedItem), this);
                formDevEdit.Show();
            }
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            if(lbPros.SelectedItem != null)
            {
                FormProEdit formProEdit = new FormProEdit(lbPros.GetItemText(lbPros.SelectedItem), this);
                formProEdit.Show();
            }
        }
    }
}