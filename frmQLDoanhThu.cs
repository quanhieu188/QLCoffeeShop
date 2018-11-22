using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNVApp
{
    public partial class frmQLDoanhThu : Form
    {
        public frmQLDoanhThu()
        {
            InitializeComponent();
        }
        List<DoanhThu> GetDoanhThu()
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM Doanh thu";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<DoanhThu> list = new List<DoanhThu>();
            string khachHang, date, soTien;
            while (dr.Read())
            {
                khachHang = dr[0].ToString();
                date = dr[1].ToString();
                soTien = dr[2].ToString();
                DoanhThu sup = new DoanhThu(khachHang, date, soTien);
                list.Add(sup);
            }
            dr.Close();
            cn.Close();
            return list;
        }
        public int CheckNV(string KhachHang)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM Doanh thu";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string khachHang;
            while (dr.Read())
            {
                khachHang = dr[0].ToString();
                if (KhachHang == khachHang)
                    return 0;
            }
            dr.Close();
            cn.Close();
            return 1;
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            List<DoanhThu> list = GetDoanhThu();
            dgvNV.DataSource = list;

            txtKhachHang.DataBindings.Add("Text", list, "KhachHang");
            txtDate.DataBindings.Add("Text", list, "Date");
            txtSoTien.DataBindings.Add("Text", list, "SoTien");
        }
        private void btFix_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string khachHang, date, soTien;
            khachHang = txtKhachHang.Text;
            date = txtDate.Text;
            soTien = txtSoTien.Text;

            if (string.IsNullOrEmpty(khachHang))
                return;
            string sql = "UPDATE Doanh thu set Ngày/Tháng/Năm = N'" + date + "',Số tiền = N'" + soTien + "' WHERE Khách hàng = '" + khachHang + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Sua that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetDoanhThu();
            cn.Close();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string khachHang;
            khachHang = txtKhachHang.Text;

            string sql = "DELETE FROM Doanh thu WHERE Khách hàng = '" + khachHang + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetDoanhThu();
            cn.Close();
        }
    }
}
