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
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM Nhân Viên";
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
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM Nhân Viên";
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

        private void frmNV_Load(object sender, EventArgs e)
        {
            List<NV> list = GetNV();
            dgvNV.DataSource = list;

            txtMaNV.DataBindings.Add("Text", list, "maNV");
            txtHo.DataBindings.Add("Text", list, "ho");
            txtTen.DataBindings.Add("Text", list, "ten");
            txtChucVu.DataBindings.Add("Text", list, "chucvu");
            txtCaLamViec.DataBindings.Add("Text", list, "calamviec");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
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
                MessageBox.Show("Them that bai", "Them Nha cung cap");
            else
            {
                string sql = "INSERT INTO Nhân Viên VALUES('" + maNV + "', N'" + ho + "', N'" + ten + "', N'" + chucvu + "', N'" + calamviec + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them Nha cung cap");
                else
                    dgvNV.DataSource = GetNV();
                cn.Close();
            }


        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string maNV, ho, ten, chucvu, calamviec;
            maNV = txtMaNV.Text;
            ho = txtHo.Text;
            ten = txtTen.Text;
            chucvu = txtChucVu.Text;
            calamviec = txtCaLamViec.Text;

            if (string.IsNullOrEmpty(maNV))
                return;
            string sql = "UPDATE Nhân Viên set Họ và tên đệm = N'" + ho + "',Tên = N'" + ten + "',Chức vụ = N'" + chucvu + "',Ca làm việc = N'" + calamviec + "' WHERE MaNV = '" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Sua that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetNV();
            cn.Close();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string maNV;
            maNV = txtMaNV.Text;

            string sql = "DELETE FROM Nhân Viên WHERE MaNV = '" + maNV + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetNV();
            cn.Close();
        }

    }
}
