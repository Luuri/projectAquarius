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
    public partial class FormProEdit : Form
    {
        string devicePath = "C:\\temp\\Devices\\Devicelist.txt";
        string productPath = "C:\\temp\\Products\\Productlist.txt";
        string productName = "";
        int productIndex;
        Form1 prevForm;
        List<Product> productlist = new List<Product>();
        List<Device> devicelist = new List<Device>();
        List<Device> prevRoute = new List<Device>();

        public FormProEdit()
        {
            InitializeComponent();
        }

        public FormProEdit(string item, Form1 form)
        {
            InitializeComponent();
            prevForm = form;
            if (File.Exists(devicePath))
            {
                devicelist = JsonConvert.DeserializeObject<List<Device>>(File.ReadAllText(devicePath)); 
                foreach(Device d in devicelist)
                {
                    cbEditProDevices.Items.Add(d.Name);
                    prevRoute.Add(d);
                }
            }
            if (File.Exists(productPath))
            {
                lbEditProRoute.Text = "";
                string temp = File.ReadAllText(productPath);
                productlist = JsonConvert.DeserializeObject<List<Product>>(temp);
                for (int i = 0; i < productlist.Count; i++)
                {
                    if (productlist[i].Name == item)
                    {
                        productIndex = i;
                        tbEditProName.Text = productName = productlist[i].Name;
                        foreach(Device device in productlist[i].Route)
                        {
                            lbEditProRoute.Items.Add(device.Name);
                        }
                    }
                }
            }
        }

        private void btnProEditSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make the changes?", "Edit Product", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                productlist = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(productPath));

                if (productName != tbEditProName.Text)
                {
                    productlist.ElementAt(productIndex).Name = tbEditProName.Text;
                }
                if (File.Exists(devicePath))
                {
                    List<Device> deviceRoute = new List<Device>();
                    for (int i = 0; i < lbEditProRoute.Items.Count; i++)
                    {
                        for (int j = 0; j < devicelist.Count; j++)
                        {
                            if (lbEditProRoute.GetItemText(lbEditProRoute.Items[i]) == devicelist[j].Name)
                            {
                                deviceRoute.Add(devicelist[j]);
                            }
                        }
                    }
                    if(deviceRoute != prevRoute)
                    {
                        productlist.ElementAt(productIndex).Route = deviceRoute;
                    }
                }
                string productString = JsonConvert.SerializeObject(productlist);
                File.WriteAllText(@productPath, productString);
                if (productName != tbEditProName.Text)
                {
                    prevForm.UpdateProList();
                }
                this.Close();
            }
        }

        private void btnProEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProEditRouteItemMove_Click(object sender, EventArgs e)
        {
            lbEditProRoute.Items.Add(cbEditProDevices.SelectedItem.ToString());
        }

        private void btnProEditRouteItemDelete_Click(object sender, EventArgs e)
        {
            lbEditProRoute.Items.Remove(lbEditProRoute.SelectedItem);
        }

        private void lbEditProRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                lbEditProRoute.Items.Remove(lbEditProRoute.SelectedItem);
            }
        }
    }
}
