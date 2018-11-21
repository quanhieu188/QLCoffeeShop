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
    public partial class frmQLKho : Form
    {
        public frmQLKho()
        {
            InitializeComponent();
        }
        List<Kho> GetKho()
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
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
        public int CheckNV(string ID)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM Kho";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string id;
            while (dr.Read())
            {
                id = dr[0].ToString();
                if (ID == id)
                    return 0;
            }
            dr.Close();
            cn.Close();
            return 1;
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            List<Kho> list = GetKho();
            dgvNV.DataSource = list;

            txtID.DataBindings.Add("Text", list, "ID");
            txtName.DataBindings.Add("Text", list, "Name");
            txtPriceS.DataBindings.Add("Text", list, "PriceS");
            txtPriceM.DataBindings.Add("Text", list, "PriceM");
            txtPriceL.DataBindings.Add("Text", list, "PriceL");
            txtSoLuong.DataBindings.Add("Text", list, "SoLuong");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id, name, prices, pricem, pricel, soluong;
            id = txtID.Text;
            name = txtName.Text;
            prices = txtPriceS.Text;
            pricem = txtPriceM.Text;
            pricel = txtPriceL.Text;
            soluong = txtSoLuong.Text;

            if (string.IsNullOrEmpty(id))
                return;
            if (CheckNV(id) == 0)
                MessageBox.Show("Them that bai", "Them Nha cung cap");
            else
            {
                string sql = "INSERT INTO Kho VALUES('" + id + "', N'" + name + "', N'" + prices + "', N'" + pricem + "', N'" + pricel + "', N'" + soluong + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them Nha cung cap");
                else
                    dgvNV.DataSource = GetKho();
                cn.Close();
            }


        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id, name, prices, pricem, pricel, soluong;
            id = txtID.Text;
            name = txtName.Text;
            prices = txtPriceS.Text;
            pricem = txtPriceM.Text;
            pricel = txtPriceL.Text;
            soluong = txtSoLuong.Text;

            if (string.IsNullOrEmpty(id))
                return;
            string sql = "UPDATE Kho set Name = N'" + name + "',Price(S) = N'" + prices + "',Price(M) = N'" + pricem + "',Price(L) = N'" + pricel + "',Số lượng = N'" + soluong + "' WHERE ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Sua that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetKho();
            cn.Close();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = QLQuanCafe; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id;
            id = txtID.Text;

            string sql = "DELETE FROM Kho WHERE ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Them Nha cung cap");
            else
                dgvNV.DataSource = GetKho();
            cn.Close();
        }
    }
}
