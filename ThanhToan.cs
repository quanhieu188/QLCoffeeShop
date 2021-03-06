﻿using System;
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
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string name, size, soLuong, price;
            name = cbName.SelectedValue.ToString();
            size = cbSize.SelectedItem.ToString();
            soLuong = numericUpDown1.Value.ToString();
            if (int.Parse(soLuong) != 0)
            {
                string sql = "SELECT * FROM Kho WHERE ID = '" + name + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = dr[1].ToString();
                    if (size == "S")
                        price = dr[2].ToString();
                    else if (size == "M")
                        price = dr[3].ToString();
                    else price = dr[4].ToString();
                    dgvDrink.Rows.Add(name, price, soLuong);
                    Tong = Tong + (double.Parse(price) * double.Parse(soLuong));
                    txtTong.Text = Tong.ToString();
                }
                dr.Close();
                cn.Close(); 
            }
        }
        List<Kho> GetKho()
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM Kho";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Kho> list = new List<Kho>();
            string id, name, prices, pricem, pricel, soluong;
            while (dr.Read())
            {
                id = dr[0].ToString();
                name = dr[1].ToString();
                prices = dr[2].ToString();
                pricem = dr[3].ToString();
                pricel = dr[4].ToString();
                soluong = dr[5].ToString();
                Kho sup = new Kho(id, name, prices, pricem, pricel, soluong);
                list.Add(sup);
            }
            dr.Close();
            cn.Close();
            return list;
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            List<Kho> list = GetKho();
            cbName.DataSource = list;
            cbName.DisplayMember = "Name";
            cbName.ValueMember = "ID";
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
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM DoanhThu";
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
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string khachHang, date;
            khachHang = txtKhachHang.Text;
            date = txtDate.Text;
            // them vao bang doanh thu
            if (string.IsNullOrEmpty(khachHang) || string.IsNullOrEmpty(date))
                return;
            if (CheckDoanhThu(khachHang, date) == 0)
                MessageBox.Show("Them that bai", "Them thanh toan");
            else
            {
                string sql = "INSERT INTO DoanhThu VALUES('" + khachHang + "', N'" + date + "', N'" + Tong + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                try
                {
                    int numberOfRows = cmd.ExecuteNonQuery();
                    if (numberOfRows <= 0)
                        MessageBox.Show("Them that bai", "Them thanh toan");
                    else
                        MessageBox.Show("Them thanh cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhap sai ngay thang nam");
                }
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
