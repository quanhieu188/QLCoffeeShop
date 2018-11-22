using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNVApp
{
    class DoanhThu
    {
        public string KhachHang { get; set; }
        public string Date { get; set; }
        public string SoTien { get; set; }

        public DoanhThu(string khachHang, string date, string soTien)
        {
            this.KhachHang = khachHang;
            this.Date = date;
            this.SoTien = soTien;
        }
    }
}
