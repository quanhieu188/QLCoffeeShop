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
        public int CheckKho(string ID)
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
        private void frmQLKho_Load(object sender, EventArgs e)
        {
            List<Kho> list = GetKho();
            dgvKho.DataSource = list;
            //txtID.DataBindings.Add("Text", list, "ID");
            //txtName.DataBindings.Add("Text", list, "Name");
            //txtPriceS.DataBindings.Add("Text", list, "PriceS");
            //txtPriceM.DataBindings.Add("Text", list, "PriceM");
            //txtPriceL.DataBindings.Add("Text", list, "PriceL");
            //txtSoLuong.DataBindings.Add("Text", list, "SoLuong");
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
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
            if (CheckKho(id) == 0)
                MessageBox.Show("Them that bai", "Them san pham");
            else
            {
                string sql = "INSERT INTO Kho VALUES('" + id + "', N'" + name + "', N'" + prices + "', N'" + pricem + "', N'" + pricel + "', N'" + soluong + "')";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                int numberOfRows = cmd.ExecuteNonQuery();
                if (numberOfRows <= 0)
                    MessageBox.Show("Them that bai", "Them san pham");
                else
                    dgvKho.DataSource = GetKho();
                cn.Close();
            }
        }
        private void btDel_Click_1(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            string id;
            id = txtID.Text;
            string sql = "DELETE FROM Kho WHERE ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Xoa that bai", "Xoa San Pham");
            else
                dgvKho.DataSource = GetKho();
            cn.Close();
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
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
            string sql = "UPDATE Kho SET Name = N'" + name + "',PriceS = N'" + prices + "',PriceM = N'" + pricem + "',PriceL = N'" + pricel + "',SoLuong = N'" + soluong + "' WHERE ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            int numberOfRows = cmd.ExecuteNonQuery();
            if (numberOfRows <= 0)
                MessageBox.Show("Sua that bai", "Sua san pham");
            else
                dgvKho.DataSource = GetKho();
            cn.Close();
        }

        private void dgvKho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvKho.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvKho.CurrentRow.Cells[1].Value.ToString();
                txtPriceS.Text = dgvKho.CurrentRow.Cells[2].Value.ToString();
                txtPriceM.Text = dgvKho.CurrentRow.Cells[3].Value.ToString();
                txtPriceL.Text = dgvKho.CurrentRow.Cells[4].Value.ToString();
                txtSoLuong.Text = dgvKho.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
