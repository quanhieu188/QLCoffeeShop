using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNVApp
{
    class Kho
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PriceS { get; set; }
        public string PriceM { get; set; }
        public string PriceL { get; set; }
        public string SoLuong { get; set; }

        public Kho(string id, string name, string prices, string pricem, string pricel, string soluong)
        {
            this.ID = id;
            this.Name = name;
            this.PriceS = prices;
            this.PriceM = pricem;
            this.PriceL = pricel;
            this.SoLuong = soluong;
        }
    }
}
