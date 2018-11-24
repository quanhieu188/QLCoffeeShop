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
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();
        }

        List<NV> GetNV()
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<NV> list = new List<NV>();
            string maNV, ho, ten, chucvu, calamviec;
            while (dr.Read())
            {
                maNV = dr[0].ToString();
                ho = dr[1].ToString();
                ten = dr[2].ToString();
                chucvu = dr[3].ToString();
                calamviec = dr[4].ToString();
                NV sup = new NV(maNV, ho, ten, chucvu, calamviec);
                list.Add(sup);
            }
            dr.Close();
            cn.Close();
            return list;
        }
        public int CheckNV(string MaNV)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string maNV;
            while (dr.Read())
            {
                maNV = dr[0].ToString();
                if (MaNV == maNV)
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
            string maNV, ho, ten, chucvu, calamviec;
            maNV = txtMaNV.Text;
            ho = txtHo.Text;
            ten = txtTen.Text;
            chucvu = txtChucVu.Text;
            calamviec = txtCaLamViec.Text;
            if (string.IsNullOrEmpty(maNV))
                return;
            if (CheckNV(maNV) == 0)
                MessageBox.Show("Them that bai", "Them nhan vien");
            else
            {
                string sql = "INSERT INTO NhanVien VALUES('" + maNV + "', N'" + ho + "', N'" + ten + "', N'" + chucvu + "', N'" + calamviec + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them nhan vien");
                else
                    dgvNV.DataSource = GetNV();
                cn.Close();
            }
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string maNV, ho, ten, chucvu, calamviec;
            maNV = txtMaNV.Text;
            ho = txtHo.Text;
            ten = txtTen.Text;
            chucvu = txtChucVu.Text;
            calamviec = txtCaLamViec.Text;
            if (string.IsNullOrEmpty(maNV))
                return;
            string sql = "UPDATE NhanVien SET Ho = N'" + ho + "',Ten = N'" + ten + "',ChucVu = N'" + chucvu + "',CaLamViec = N'" + calamviec + "' WHERE MaNV = '" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Sua that bai", "Sua Nhan Vien");
            else
                dgvNV.DataSource = GetNV();
            cn.Close();
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string maNV, ho, ten, chucvu, calamviec;
            maNV = txtMaNV.Text;
            ho = txtHo.Text;
            ten = txtTen.Text;
            chucvu = txtChucVu.Text;
            calamviec = txtCaLamViec.Text;
            string sql = "DELETE FROM NhanVien WHERE MaNV = '" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Xoa Nhan Vien");
            else
                dgvNV.DataSource = GetNV();
            cn.Close();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            List<NV> list = GetNV();
            dgvNV.DataSource = list;
            //txtMaNV.DataBindings.Add("Text", list, "MaNV");
            //txtHo.DataBindings.Add("Text", list, "Ho");
            //txtTen.DataBindings.Add("Text", list, "Ten");
            //txtChucVu.DataBindings.Add("Text", list, "ChucVu");
            //txtCaLamViec.DataBindings.Add("Text", list, "CaLamViec");
        }

        private void dgvNV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
                txtHo.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
                txtTen.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
                txtChucVu.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
                txtCaLamViec.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
