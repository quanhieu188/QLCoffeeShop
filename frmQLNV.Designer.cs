namespace QLNVApp
{
    partial class frmQLNV
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
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbCaLamViec = new System.Windows.Forms.Label();
            this.txtCaLamViec = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
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
            this.MaNV,
            this.Ho,
            this.Ten,
            this.ChucVu,
            this.CaLamViec});
            this.dgvNV.Location = new System.Drawing.Point(11, 127);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(660, 304);
            this.dgvNV.TabIndex = 1;
            this.dgvNV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellEnter);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 65;
            // 
            // Ho
            // 
            this.Ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // CaLamViec
            // 
            this.CaLamViec.DataPropertyName = "CaLamViec";
            this.CaLamViec.HeaderText = "Ca làm việc";
            this.CaLamViec.Name = "CaLamViec";
            this.CaLamViec.Width = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbChucVu);
            this.groupBox1.Controls.Add(this.lbCaLamViec);
            this.groupBox1.Controls.Add(this.txtCaLamViec);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.lbTen);
            this.groupBox1.Controls.Add(this.lbHo);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Location = new System.Drawing.Point(274, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(397, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(194, 20);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(47, 13);
            this.lbChucVu.TabIndex = 9;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // lbCaLamViec
            // 
            this.lbCaLamViec.AutoSize = true;
            this.lbCaLamViec.Location = new System.Drawing.Point(194, 43);
            this.lbCaLamViec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCaLamViec.Name = "lbCaLamViec";
            this.lbCaLamViec.Size = new System.Drawing.Size(67, 13);
            this.lbCaLamViec.TabIndex = 8;
            this.lbCaLamViec.Text = "Ca Làm Việc";
            // 
            // txtCaLamViec
            // 
            this.txtCaLamViec.Location = new System.Drawing.Point(265, 40);
            this.txtCaLamViec.Margin = new System.Windows.Forms.Padding(2);
            this.txtCaLamViec.Name = "txtCaLamViec";
            this.txtCaLamViec.Size = new System.Drawing.Size(128, 20);
            this.txtCaLamViec.TabIndex = 7;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(265, 17);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(128, 20);
            this.txtChucVu.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(47, 17);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(128, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(47, 40);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(128, 20);
            this.txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(47, 63);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(128, 20);
            this.txtTen.TabIndex = 3;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(4, 65);
            this.lbTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(26, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(4, 42);
            this.lbHo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(21, 13);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Họ";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(4, 20);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(22, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDel);
            this.groupBox2.Controls.Add(this.btFix);
            this.groupBox2.Controls.Add(this.btAdd);
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
            this.btDel.Location = new System.Drawing.Point(179, 22);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(56, 19);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
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
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(4, 22);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 19);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Windows Form Designer generated code

        #endregion
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbCaLamViec;
        private System.Windows.Forms.TextBox txtCaLamViec;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLamViec;
    }
}