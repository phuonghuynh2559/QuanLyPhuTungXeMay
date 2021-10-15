namespace DoanCNPM
{
    partial class ChiTietNhap
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
            this.bttrove = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.dgvChitietHDN = new System.Windows.Forms.DataGridView();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtMahdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvXE = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXE)).BeginInit();
            this.SuspendLayout();
            // 
            // bttrove
            // 
            this.bttrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttrove.Location = new System.Drawing.Point(748, 292);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(207, 29);
            this.bttrove.TabIndex = 56;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = true;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(369, 292);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 29);
            this.btThem.TabIndex = 55;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenPT);
            this.groupBox2.Controls.Add(this.dgvChitietHDN);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.txtMahdn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(157, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 353);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập chi tiết hóa đơn nhập";
            // 
            // txtTenPT
            // 
            this.txtTenPT.Enabled = false;
            this.txtTenPT.Location = new System.Drawing.Point(165, 84);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(165, 23);
            this.txtTenPT.TabIndex = 7;
            // 
            // dgvChitietHDN
            // 
            this.dgvChitietHDN.AllowUserToAddRows = false;
            this.dgvChitietHDN.AllowUserToDeleteRows = false;
            this.dgvChitietHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietHDN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChitietHDN.Location = new System.Drawing.Point(3, 151);
            this.dgvChitietHDN.Name = "dgvChitietHDN";
            this.dgvChitietHDN.ReadOnly = true;
            this.dgvChitietHDN.RowHeadersWidth = 51;
            this.dgvChitietHDN.Size = new System.Drawing.Size(801, 199);
            this.dgvChitietHDN.TabIndex = 6;
            this.dgvChitietHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitietHDN_CellClick);
            this.dgvChitietHDN.Click += new System.EventHandler(this.dgvChitietHDN_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(453, 39);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(165, 23);
            this.txtsoluong.TabIndex = 5;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txtDongia
            // 
            this.txtDongia.Enabled = false;
            this.txtDongia.Location = new System.Drawing.Point(453, 79);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(165, 23);
            this.txtDongia.TabIndex = 5;
            // 
            // txtMahdn
            // 
            this.txtMahdn.Enabled = false;
            this.txtMahdn.Location = new System.Drawing.Point(165, 36);
            this.txtMahdn.Name = "txtMahdn";
            this.txtMahdn.Size = new System.Drawing.Size(165, 23);
            this.txtMahdn.TabIndex = 4;
            this.txtMahdn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMahdn_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phụ tùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 218);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phụ tùng";
            // 
            // dgvXE
            // 
            this.dgvXE.AllowUserToAddRows = false;
            this.dgvXE.AllowUserToDeleteRows = false;
            this.dgvXE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvXE.Location = new System.Drawing.Point(3, 21);
            this.dgvXE.Name = "dgvXE";
            this.dgvXE.ReadOnly = true;
            this.dgvXE.RowHeadersWidth = 51;
            this.dgvXE.Size = new System.Drawing.Size(798, 194);
            this.dgvXE.TabIndex = 1;
            this.dgvXE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXE_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 59;
            this.label1.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(471, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 29);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(573, 292);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 29);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ChiTietNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1170, 725);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChiTietNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChiTietNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttrove;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChitietHDN;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtMahdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvXE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenPT;
    }
}