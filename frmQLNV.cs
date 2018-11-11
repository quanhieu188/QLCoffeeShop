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
            string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM NV";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<NV> list = new List<NV>();
            string id, name, address;
            while (dr.Read())
            {
                id = dr[0].ToString();
                name = dr[1].ToString();
                address = dr[2].ToString();

                NV sup = new NV(id, name, address);
                list.Add(sup);
            }
            dr.Close();
            cn.Close();
            return list;
        }
        public int CheckNV(string Id)
        {
            string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM NV";
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
                if (Id == id)
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

            txtId.DataBindings.Add("Text", list, "id");
            txtName.DataBindings.Add("Text", list, "name");
            txtAddress.DataBindings.Add("Text", list, "address");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id, name, address;
            id = txtId.Text;
            name = txtName.Text;
            address = txtAddress.Text;

            if (string.IsNullOrEmpty(id))
                return;
            if (CheckNV(id) == 0)
                MessageBox.Show("Them that bai", "Them Nha cung cap");
            else
            {
                string sql = "INSERT INTO NV VALUES('" + id + "', N'" + name + "', N'" + address + "')";
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
            string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id, name, address;
            id = txtId.Text;
            name = txtName.Text;
            address = txtAddress.Text;

            if (string.IsNullOrEmpty(id))
                return;
            string sql = "UPDATE NV set Name = N'" + name + "',Address = N'" + address + "' WHERE Id = '" + id + "'";
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
            string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
            SqlConnection cn = new SqlConnection(cnStr);

            string id;
            id = txtId.Text;

            string sql = "DELETE FROM NV WHERE Id = '" + id + "'";
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
