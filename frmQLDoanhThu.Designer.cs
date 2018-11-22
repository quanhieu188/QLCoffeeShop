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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToOrderColumns = true;
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.Date,
            this.SoTien});
            this.dgvNV.Location = new System.Drawing.Point(11, 127);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(498, 304);
            this.dgvNV.TabIndex = 1;
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
            this.lbDate.Text = "Ngày/Tháng/Năm";
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
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(135, 23);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(56, 19);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(44, 22);
            this.btFix.Margin = new System.Windows.Forms.Padding(2);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(56, 19);
            this.btFix.TabIndex = 1;
            this.btFix.Text = "Sửa";
            this.btFix.UseVisualStyleBackColor = true;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Width = 90;
            // 
            // Date
            // 
            this.Date.HeaderText = "Ngày/Tháng/Năm";
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 65;
            // 
            // frmQLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmQLDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNV;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
    }
}