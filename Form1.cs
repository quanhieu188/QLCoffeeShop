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
    public partial class frmCoffeeShop : Form
    {
        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        private void frmCoffeeShop_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            frmLogin frm = new frmLogin();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
