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
    public partial class FormDevEdit : Form
    {
        string devicePath = "C:\\temp\\Devices\\Devicelist.txt";
        string deviceName = "";
        int deviceIndex;
        Form1 prevForm;
        List<Device> devicelist = new List<Device>();

        public FormDevEdit()
        {
            InitializeComponent();
        }

        public FormDevEdit(string item, Form1 form)
        {
            InitializeComponent();
            prevForm = form;
            if (File.Exists(devicePath))
            {
                string temp = File.ReadAllText(devicePath);
                devicelist = JsonConvert.DeserializeObject<List<Device>>(temp);
                for (int i = 0; i < devicelist.Count; i++)
                {
                    if(devicelist[i].Name == item)
                    {
                        deviceIndex = i;
                        tbEditDevName.Text = deviceName = devicelist[i].Name;
                        tbEditDevIP.Text = devicelist[i].IP;
                        string[] wholeAdd = devicelist[i].Address.Split(new[] { ", " }, StringSplitOptions.None);
                        tbEditDevAddress.Text = wholeAdd[0];
                        tbEditDevPostCode.Text = wholeAdd[1];
                    }
                }
            }           
        }

        private void btnDevEditSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make the changes?", "Edit Device", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                devicelist = JsonConvert.DeserializeObject<List<Device>>(File.ReadAllText(devicePath));

                if (deviceName != tbEditDevName.Text)
                {
                    devicelist.ElementAt(deviceIndex).Name = tbEditDevName.Text;                    
                }
                devicelist.ElementAt(deviceIndex).IP = tbEditDevIP.Text;
                devicelist.ElementAt(deviceIndex).Address = tbEditDevAddress.Text + ", " + tbEditDevPostCode.Text;
                string deviceString = JsonConvert.SerializeObject(devicelist);
                File.WriteAllText(@devicePath, deviceString);
                if (deviceName != tbEditDevName.Text)
                {
                    prevForm.UpdateDevList();
                }
                this.Close();
            }            
        }

        private void btnDevEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}