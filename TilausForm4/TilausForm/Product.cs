using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilausForm
{
    public class Product
    {
        public string Name { get; set; }
        public List<Device> route { get; set; }
        public string orderName { get; set; }
        public string orderAddress { get; set; }
    }
}
