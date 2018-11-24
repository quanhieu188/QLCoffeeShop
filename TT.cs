using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNVApp
{
    class TT
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string SoLuong { get; set; }
        public TT(string name,string price,string soLuong)
        {
            this.Name = name;
            this.Price = price;
            this.SoLuong = soLuong;
        }
    }
}
