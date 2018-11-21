using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNVApp
{
    class NV
    {
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string ChucVu { get; set; }
        public string CaLamViec { get; set; }

        public NV(string maNV, string ho, string ten, string chucvu, string calamviec)
        {
            this.MaNV = maNV;
            this.Ho = ho;
            this.Ten = ten;
            this.ChucVu = chucvu;
            this.CaLamViec = calamviec;
        }
    }
}
