using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Can nhap du username va password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (userName == "admin" && passWord == "123456")
                //if (Login(userName, passWord) == true)
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
        //private bool Login(string username, string password)
        //{
        //    string cnStr = "Server = .; Database = CoffeeShop; Integrated security = true;";
        //    SqlConnection cn = new SqlConnection(cnStr);
        //    cn.Open();
        //    string sql = "SELECT COUNT(UserName) FROM Users WHERE UserName = '" + username + "' AND Password = '" + password + "'";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = sql;
        //    cmd.CommandType = CommandType.Text;
        //    int count = (int)cmd.ExecuteScalar();
        //    cn.Close();
        //    if (count == 1)
        //        return true;
        //    else
        //        return false;
        //}
    }
}
