using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNVApp
{
    public partial class ThanhToan : Form
    {
        double Tong = 0.0;
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string name, size, soLuong;
            string price;
            name = cbName.SelectedItem.ToString();
            size = cbSize.SelectedItem.ToString();
            soLuong = numericUpDown1.Value.ToString();



            string sql = "SELECT * FROM Kho WHERE Name = '" + name + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (size == "S")
                price = dr[2].ToString();
            else if (size == "M")
                price = dr[3].ToString();
            else price = dr[4].ToString();
            dgvDrink.Rows.Add(name, price, soLuong);
            Tong = Tong + ( double.Parse(price) * double.Parse(soLuong));
            txtTong.Text = Tong.ToString();
            dr.Close();
            cn.Close();

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            dgvDrink.Rows.Clear();
            txtTong.Text = "";
            Tong = 0;
            cbName.SelectedItem = null;
            cbSize.SelectedItem = null;
            numericUpDown1.Value = 0;

        }

        public int CheckDoanhThu(string KhachHang, string Date)
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

            string khachHang, date, tong;
            while (dr.Read())
            {
                khachHang = dr[0].ToString();
                date = dr[1].ToString();
                tong = dr[2].ToString();
                if (KhachHang == khachHang && Date == date && Tong == double.Parse(tong))
                    return 0;
            }
            dr.Close();
            cn.Close();
            return 1;
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string khachHang, date, nv;
            khachHang = txtKhachHang.Text;
            date = txtDate.Text;
            nv = txtNhanVien.Text;
            // them vao bang doanh thu
            if (string.IsNullOrEmpty(khachHang) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(nv))
                return;
            if (CheckDoanhThu(khachHang, date) == 0)
                MessageBox.Show("Them that bai", "Them Nha cung cap");
            else
            {
                string sql = "INSERT INTO Doanh Thu VALUES('" + khachHang + "', N'" + date + "', N'" + Tong + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them Nha cung cap");
                else
                    MessageBox.Show("Them thanh cong");
                cn.Close();
            }

            // them vao bang
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dgvDrink.Rows.Count > 1)
            {
                int x = dgvDrink.SelectedRows[0].Index;
                int y = dgvDrink.Columns[2].Index;
                int z = dgvDrink.Columns[1].Index;
                double soLuong = double.Parse(dgvDrink.Rows[x].Cells[y].Value.ToString());
                double price = double.Parse(dgvDrink.Rows[x].Cells[z].Value.ToString());
                Tong -= soLuong * price;
                txtTong.Text = Tong.ToString();
                dgvDrink.Rows.RemoveAt(dgvDrink.SelectedRows[0].Index);
            }
            else
            {
                dgvDrink.Rows.Clear();
                txtTong.Text = "";
                Tong = 0;
            }
            
        }
    }
}
