namespace DoanCNPM
{
    partial class QL_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NhapHang));
            this.grdh = new System.Windows.Forms.GroupBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.dgvhoadonnhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsncc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.bttrove = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdh
            // 
            this.grdh.Controls.Add(this.txtTenNCC);
            this.grdh.Controls.Add(this.txtTongTien);
            this.grdh.Controls.Add(this.label3);
            this.grdh.Controls.Add(this.dtpkNgaynhap);
            this.grdh.Controls.Add(this.txtmahdn);
            this.grdh.Controls.Add(this.dgvhoadonnhap);
            this.grdh.Controls.Add(this.label5);
            this.grdh.Controls.Add(this.label4);
            this.grdh.Controls.Add(this.label2);
            this.grdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdh.Location = new System.Drawing.Point(12, 295);
            this.grdh.Name = "grdh";
            this.grdh.Size = new System.Drawing.Size(639, 404);
            this.grdh.TabIndex = 43;
            this.grdh.TabStop = false;
            this.grdh.Text = "Lập đơn hàng nhập";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Location = new System.Drawing.Point(439, 40);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(164, 23);
            this.txtTenNCC.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(94, 97);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(158, 23);
            this.txtTongTien.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn giá";
            // 
            // dtpkNgaynhap
            // 
            this.dtpkNgaynhap.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgaynhap.Enabled = false;
            this.dtpkNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaynhap.Location = new System.Drawing.Point(433, 97);
            this.dtpkNgaynhap.Name = "dtpkNgaynhap";
            this.dtpkNgaynhap.Size = new System.Drawing.Size(170, 23);
            this.dtpkNgaynhap.TabIndex = 6;
            // 
            // txtmahdn
            // 
            this.txtmahdn.Enabled = false;
            this.txtmahdn.Location = new System.Drawing.Point(94, 40);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(158, 23);
            this.txtmahdn.TabIndex = 3;
            // 
            // dgvhoadonnhap
            // 
            this.dgvhoadonnhap.AllowUserToAddRows = false;
            this.dgvhoadonnhap.AllowUserToDeleteRows = false;
            this.dgvhoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvhoadonnhap.Location = new System.Drawing.Point(3, 134);
            this.dgvhoadonnhap.Name = "dgvhoadonnhap";
            this.dgvhoadonnhap.ReadOnly = true;
            this.dgvhoadonnhap.RowHeadersWidth = 51;
            this.dgvhoadonnhap.Size = new System.Drawing.Size(618, 263);
            this.dgvhoadonnhap.TabIndex = 2;
            this.dgvhoadonnhap.Click += new System.EventHandler(this.dgvhoadonnhap_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANH";
            this.Column1.HeaderText = "Mã Nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANCC";
            this.Column2.HeaderText = "Mã NCC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYNHAP";
            this.Column3.HeaderText = "Ngày nhập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TONGTIEN";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TINHTRANG";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên NCC:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsncc);
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 229);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_dsncc
            // 
            this.dgv_dsncc.AllowUserToAddRows = false;
            this.dgv_dsncc.AllowUserToDeleteRows = false;
            this.dgv_dsncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dsncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsncc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dsncc.Location = new System.Drawing.Point(3, 55);
            this.dgv_dsncc.Name = "dgv_dsncc";
            this.dgv_dsncc.ReadOnly = true;
            this.dgv_dsncc.RowHeadersWidth = 51;
            this.dgv_dsncc.Size = new System.Drawing.Size(635, 171);
            this.dgv_dsncc.TabIndex = 0;
            this.dgv_dsncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsncc_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.bttrove);
            this.groupBox2.Controls.Add(this.btTimkiem);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(665, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(288, 229);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 60;
            this.button1.Text = "Lập Chi Tiết Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(22, 143);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 32);
            this.btXoa.TabIndex = 55;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(138, 80);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(116, 37);
            this.btThem.TabIndex = 57;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // bttrove
            // 
            this.bttrove.BackColor = System.Drawing.Color.White;
            this.bttrove.Image = ((System.Drawing.Image)(resources.GetObject("bttrove.Image")));
            this.bttrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttrove.Location = new System.Drawing.Point(138, 80);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(116, 37);
            this.bttrove.TabIndex = 58;
            this.bttrove.Text = "     Trở về";
            this.bttrove.UseVisualStyleBackColor = false;
            // 
            // btTimkiem
            // 
            this.btTimkiem.BackColor = System.Drawing.Color.White;
            this.btTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimkiem.Image")));
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(22, 80);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(110, 37);
            this.btTimkiem.TabIndex = 59;
            this.btTimkiem.Text = "       Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = false;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click_1);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(22, 36);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(232, 20);
            this.txtten.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nhập tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label1.Location = new System.Drawing.Point(321, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 46);
            this.label1.TabIndex = 61;
            this.label1.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // QL_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(958, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdh);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QL_NhapHang";
            this.Text = "QL_NhapHang";
            this.Load += new System.EventHandler(this.QL_NhapHang_Load);
            this.grdh.ResumeLayout(false);
            this.grdh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsncc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grdh;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.DataGridView dgvhoadonnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsncc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button bttrove;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgaynhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}