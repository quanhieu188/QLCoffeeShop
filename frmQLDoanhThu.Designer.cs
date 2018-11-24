namespace QLNVApp
{
    partial class frmQLDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.lbSoTien);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.lbKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(274, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(100, 17);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(128, 20);
            this.txtKhachHang.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(100, 39);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(128, 20);
            this.txtDate.TabIndex = 4;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(100, 62);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(128, 20);
            this.txtSoTien.TabIndex = 3;
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(4, 65);
            this.lbSoTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(40, 13);
            this.lbSoTien.TabIndex = 2;
            this.lbSoTien.Text = "Số tiền";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(4, 42);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(95, 13);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Tháng/Ngày/Năm";
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(4, 20);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lbKhachHang.TabIndex = 0;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAdd);
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Controls.Add(this.btFix);
            this.groupBox2.Location = new System.Drawing.Point(11, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(239, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(4, 22);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 19);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(179, 23);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(56, 19);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click_1);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(93, 22);
            this.btFix.Margin = new System.Windows.Forms.Padding(2);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(56, 19);
            this.btFix.TabIndex = 1;
            this.btFix.Text = "Sửa";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click_1);
            // 
            // SoTien
            // 
            this.SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày/Tháng/Năm";
            this.Date.Name = "Date";
            // 
            // KhachHang
            // 
            this.KhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhachHang.DataPropertyName = "KhachHang";
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToOrderColumns = true;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDoanhThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.Date,
            this.SoTien});
            this.dgvDoanhThu.Location = new System.Drawing.Point(11, 127);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(498, 304);
            this.dgvDoanhThu.TabIndex = 1;
            this.dgvDoanhThu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellEnter);
            // 
            // frmQLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDoanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmQLDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Doanh Thu";
            this.Load += new System.EventHandler(this.frmQLDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
    }
}