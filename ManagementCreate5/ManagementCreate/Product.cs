using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCreate
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Device> Route { get; set; }

        public Product CreateProduct(string n, List<Device> rt)
        {
            Product pro = new Product();
            pro.Name = n;
            pro.Route = rt;

            return pro;
        }

        public Product CreateProduct(int id, string n, List<Device> rt)
        {
            Product pro = new Product();
            pro.Id = id;
            pro.Name = n;
            pro.Route = rt;

            return pro;
        }
    }
}
