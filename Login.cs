using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLNVApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassWord.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Can nhap du username va password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Login(userName, passWord) == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Username hoac password khong dung!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        txtUserName.Focus();
                    }
                }
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool Login(string username, string password)
        {
            string cnStr = "Data Source=DESKTOP-67RKQE5\\SQLEXPRESS;Initial Catalog=QLQuanCafe;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            string sql = "SELECT COUNT(Account) FROM TaiKhoan WHERE Account = '" + username + "' AND Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            int count = (int)cmd.ExecuteScalar();
            cn.Close();
            if (count == 1)
                return true;
            else
                return false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btLogin.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                btCancel.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
