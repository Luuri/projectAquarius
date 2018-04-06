using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

namespace TilausForm
{

    public partial class Form1 : Form
    {
        List<Product> productlist = new List<Product>();
        string productpath = "C:\\temp\\Products\\productlist.txt";
        string ipaddress = "10.211.48.114";
        bool ipSet = true;
        bool ipSetVisible = false;
        Device d1, d2, d3;
        public Form1()
        {
            d1 = CreateDevice("D1", "Hall A");
            d2 = CreateDevice("D2", "Hall B");
            d3 = CreateDevice("D3", "Hall C");
            InitializeComponent();
            if (File.Exists(productpath))
            {
                string temp = File.ReadAllText(productpath);
                productlist = JsonConvert.DeserializeObject<List<Product>>(temp);
                cbProducts.Items.Clear();
                for (int i = 0; i < productlist.Count; i++)
                {
                    cbProducts.Items.Add(productlist.ElementAt(i).Name);
                }
            }
            tbManagementIP.Text = ipaddress;
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            string fname = tbFname.Text;
            string lname = tbLname.Text;
            string wname = tbFname.Text + " " + tbLname.Text;
            string selProduct = cbProducts.SelectedText;
            string oAddress = tbAddress.Text + ", " + tbPostCode.Text;


            if (fname != "" && lname != "" && tbAddress.Text != "" && tbPostCode.Text != "")
            {
                int proNum = cbProducts.SelectedIndex;
                List<Device> list = new List<Device>();
                Product product = new Product();
                list = productlist.ElementAt(proNum).route;
                product = CreateProduct(selProduct, list, wname, oAddress);

                /* --- Here the Product will be sent to the Management node. --- */

                string byproduct = JsonConvert.SerializeObject(product);
                string url = "http://" + ipaddress + "/products/post/";
                lblMsg.Text = byproduct.ToString();               
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(url + byproduct, null);
                    if (response.IsSuccessStatusCode)
                    {
                        lblMsg.Text = "Your order has been received.";
                        StreamWriter sw = new StreamWriter("C:\\temp\\test.txt");
                        sw.Write(byproduct);
                        sw.Close();
                    }
                    else
                    {
                        lblMsg.Text = response.ToString();
                    }
                }
            }
            else { lblMsg.Text = "Woops, something went wrong."; }
        }

        private void btnManagementIP_Click(object sender, EventArgs e)
        {
            if (ipSet)
            {
                tbManagementIP.Enabled = true;
                btnManagementIP.Text = "Ok";
                lblMsg.Text = "Set IP.";
                ipSet = false;
            }
            else
            {               
                tbManagementIP.Enabled = false;
                ipaddress = tbManagementIP.Text;
                btnManagementIP.Text = "Change Management IP";
                lblMsg.Text = "Management IP has been set to " + ipaddress;
                ipSet = true;
            }
            
        }

        private void miManagementIP_Click(object sender, EventArgs e)
        {
            if(ipSetVisible)
            {
                tbManagementIP.Visible = btnManagementIP.Visible = ipSetVisible = false;
                miManagementIP.Text = "Set Management Center IP";
            }
            else
            {
                tbManagementIP.Visible = btnManagementIP.Visible = ipSetVisible = true;
                miManagementIP.Text = "Hide Management Center IP";
            }
        }

        public Product CreateProduct(string pname, List<Device> plist, string oname, string oadd)
        {
            Product pro = new Product();
            pro.Name = pname;
            pro.route = plist;
            pro.orderName = oname;
            pro.orderAddress = oadd;

            return pro;
        }

        public Device CreateDevice(string n, string add)
        {
            Device dev = new Device();
            dev.Name = n;
            dev.Address = add;

            return dev;
        }
    }
}
