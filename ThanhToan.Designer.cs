namespace QLNVApp
{
    partial class ThanhToan
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btThem = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(6, 21);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 6;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(143, 58);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa món";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(6, 58);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 6;
            this.lbSize.Text = "Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(236, 37);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(143, 19);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm món";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.Add_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbSize.Location = new System.Drawing.Point(39, 55);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(88, 21);
            this.cbSize.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDrink);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvDrink
            // 
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Price,
            this.SoLuong});
            this.dgvDrink.Location = new System.Drawing.Point(6, 19);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.Size = new System.Drawing.Size(351, 201);
            this.dgvDrink.TabIndex = 0;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Name";
            this.Ten.HeaderText = "Name";
            this.Ten.Name = "Ten";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKhachHang);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.lbKhachHang);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Location = new System.Drawing.Point(297, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(120, 61);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtKhachHang.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(120, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 3;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.Location = new System.Drawing.Point(19, 64);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(65, 13);
            this.lbKhachHang.TabIndex = 1;
            this.lbKhachHang.Text = "Khách hàng";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(19, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(95, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Tháng/Ngày/Năm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btLamMoi);
            this.groupBox4.Controls.Add(this.btThanhToan);
            this.groupBox4.Controls.Add(this.txtTong);
            this.groupBox4.Controls.Add(this.lbTong);
            this.groupBox4.Location = new System.Drawing.Point(390, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 226);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(9, 84);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btLamMoi.TabIndex = 3;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(95, 84);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btThanhToan.TabIndex = 2;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(55, 35);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(115, 20);
            this.txtTong.TabIndex = 1;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(6, 36);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(43, 16);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "Tổng:";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 356);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}