namespace QLNVApp
{
    partial class frmQLKho
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
            this.lbPriceM = new System.Windows.Forms.Label();
            this.lbPriceL = new System.Windows.Forms.Label();
            this.txtPriceL = new System.Windows.Forms.TextBox();
            this.txtPriceM = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPriceS = new System.Windows.Forms.TextBox();
            this.lbPriceS = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
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
            this.ID,
            this.Name,
            this.PriceS,
            this.PriceM,
            this.PriceL,
            this.SoLuong});
            this.dgvNV.Location = new System.Drawing.Point(11, 127);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(660, 304);
            this.dgvNV.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSoLuong);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.lbPriceM);
            this.groupBox1.Controls.Add(this.lbPriceL);
            this.groupBox1.Controls.Add(this.txtPriceL);
            this.groupBox1.Controls.Add(this.txtPriceM);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPriceS);
            this.groupBox1.Controls.Add(this.lbPriceS);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Location = new System.Drawing.Point(274, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(397, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbPriceM
            // 
            this.lbPriceM.AutoSize = true;
            this.lbPriceM.Location = new System.Drawing.Point(194, 20);
            this.lbPriceM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriceM.Name = "lbPriceM";
            this.lbPriceM.Size = new System.Drawing.Size(46, 13);
            this.lbPriceM.TabIndex = 9;
            this.lbPriceM.Text = "Price(M)";
            // 
            // lbPriceL
            // 
            this.lbPriceL.AutoSize = true;
            this.lbPriceL.Location = new System.Drawing.Point(194, 43);
            this.lbPriceL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriceL.Name = "lbPriceL";
            this.lbPriceL.Size = new System.Drawing.Size(43, 13);
            this.lbPriceL.TabIndex = 8;
            this.lbPriceL.Text = "Price(L)";
            // 
            // txtPriceL
            // 
            this.txtPriceL.Location = new System.Drawing.Point(265, 40);
            this.txtPriceL.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceL.Name = "txtPriceL";
            this.txtPriceL.Size = new System.Drawing.Size(128, 20);
            this.txtPriceL.TabIndex = 7;
            // 
            // txtPriceM
            // 
            this.txtPriceM.Location = new System.Drawing.Point(265, 17);
            this.txtPriceM.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceM.Name = "txtPriceM";
            this.txtPriceM.Size = new System.Drawing.Size(128, 20);
            this.txtPriceM.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(47, 17);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPriceS
            // 
            this.txtPriceS.Location = new System.Drawing.Point(47, 63);
            this.txtPriceS.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceS.Name = "txtPriceS";
            this.txtPriceS.Size = new System.Drawing.Size(128, 20);
            this.txtPriceS.TabIndex = 3;
            // 
            // lbPriceS
            // 
            this.lbPriceS.AutoSize = true;
            this.lbPriceS.Location = new System.Drawing.Point(4, 65);
            this.lbPriceS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriceS.Name = "lbPriceS";
            this.lbPriceS.Size = new System.Drawing.Size(44, 13);
            this.lbPriceS.TabIndex = 2;
            this.lbPriceS.Text = "Price(S)";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(4, 42);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(4, 20);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
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
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 60;
            // 
            // PriceS
            // 
            this.PriceS.HeaderText = "Price(S)";
            this.PriceS.Name = "PriceS";
            this.PriceS.Width = 69;
            // 
            // PriceM
            // 
            this.PriceM.HeaderText = "Price(M)";
            this.PriceM.Name = "PriceM";
            this.PriceM.Width = 71;
            // 
            // PriceL
            // 
            this.PriceL.HeaderText = "Price(L)";
            this.PriceL.Name = "PriceL";
            this.PriceL.Width = 68;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 74;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(265, 63);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(128, 20);
            this.txtSoLuong.TabIndex = 10;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(194, 65);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbSoLuong.TabIndex = 11;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // frmQLKho
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
            this.Name = "frmQLKho";
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
        private System.Windows.Forms.Label lbPriceS;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPriceS;
        private System.Windows.Forms.Label lbPriceL;
        private System.Windows.Forms.TextBox txtPriceL;
        private System.Windows.Forms.TextBox txtPriceM;
        private System.Windows.Forms.Label lbPriceM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
    }
}