using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNVApp
{
    class NV
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public NV(string id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }
    }
}
