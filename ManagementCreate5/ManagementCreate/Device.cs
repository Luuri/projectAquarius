using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCreate
{
    class Device
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public string Address { get; set; }

        public Device CreateDevice(string n, string ip, string add)
        {
            Device dev = new Device();
            dev.Name = n;
            dev.IP = ip;
            dev.Address = add;

            return dev;
        }
    }
}
