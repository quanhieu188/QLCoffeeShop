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
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM DoanhThu";
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
        public int CheckDT(string KhachHang)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM DoanhThu";
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
        private void btAdd_Click(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string khachHang, date, soTien;
            khachHang = txtKhachHang.Text;
            date = txtDate.Text;
            soTien = txtSoTien.Text;
            if (string.IsNullOrEmpty(khachHang))
                return;
            if (CheckDT(khachHang) == 0)
                MessageBox.Show("Them that bai", "Them doanh thu");
            else
            {
                string sql = "INSERT INTO DoanhThu VALUES('" + khachHang + "', N'" + date + "', N'" + soTien + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them doanh thu");
                else
                    dgvDoanhThu.DataSource = GetDoanhThu();
                cn.Close();
            }
        }

        private void frmQLDoanhThu_Load(object sender, EventArgs e)
        {
            List<DoanhThu> list = GetDoanhThu();
            dgvDoanhThu.DataSource = list;
            //txtKhachHang.DataBindings.Add("Text", list, "KhachHang");
            //txtDate.DataBindings.Add("Text", list, "Date");
            //txtSoTien.DataBindings.Add("Text", list, "SoTien");
        }

        private void btFix_Click_1(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string khachHang, date, soTien;
            khachHang = txtKhachHang.Text;
            date = txtDate.Text;
            soTien = txtSoTien.Text;
            if (string.IsNullOrEmpty(khachHang))
                return;
            string sql = "UPDATE DoanhThu SET NgayThangNam = N'" + date + "',SoTien = N'" + soTien + "' WHERE KhachHang = '" + khachHang + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            try
            {
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Sua that bai", "Sua doanh thu");
                else
                    dgvDoanhThu.DataSource = GetDoanhThu();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap sai ngay thang nam");
            }
            cn.Close();
        }
        private void btDel_Click_1(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string khachHang,ngayThangNam,soTien;
            khachHang = txtKhachHang.Text;
            ngayThangNam = txtDate.Text;
            soTien = txtSoTien.Text;
            string sql = "DELETE FROM DoanhThu WHERE KhachHang = '" + khachHang + "' AND NgayThangNam = '" + ngayThangNam + "' AND SoTien = '" + soTien + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Xoa doanh thu");
            else
                dgvDoanhThu.DataSource = GetDoanhThu();
            cn.Close();
        }

        private void dgvDoanhThu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKhachHang.Text = dgvDoanhThu.CurrentRow.Cells[0].Value.ToString();
                txtDate.Text = dgvDoanhThu.CurrentRow.Cells[1].Value.ToString();
                txtSoTien.Text = dgvDoanhThu.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
