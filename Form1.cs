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
        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKho frm = new frmQLKho();
            frm.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDoanhThu frm = new frmQLDoanhThu();
            frm.ShowDialog();
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

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToan frm = new ThanhToan();
            frm.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmQLDoanhThu frm = new frmQLDoanhThu();
            frm.ShowDialog();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKho frm = new frmQLKho();
            frm.ShowDialog();
        }
    }
}
