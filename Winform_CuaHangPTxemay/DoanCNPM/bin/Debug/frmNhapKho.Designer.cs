namespace DoanCNPM
{
    partial class frmNhapKho
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
            this.dtgvCTPHN = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoaSPLoi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPHN)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCTPHN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(470, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(449, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn đặt hàng";
            // 
            // dtgvCTPHN
            // 
            this.dtgvCTPHN.AllowUserToAddRows = false;
            this.dtgvCTPHN.AllowUserToDeleteRows = false;
            this.dtgvCTPHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCTPHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPHN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvCTPHN.Location = new System.Drawing.Point(2, 20);
            this.dtgvCTPHN.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCTPHN.Name = "dtgvCTPHN";
            this.dtgvCTPHN.ReadOnly = true;
            this.dtgvCTPHN.RowTemplate.Height = 24;
            this.dtgvCTPHN.Size = new System.Drawing.Size(445, 164);
            this.dtgvCTPHN.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvPhieuNhap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(455, 186);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn nhập hàng";
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AllowUserToAddRows = false;
            this.dtgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dtgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(2, 20);
            this.dtgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.ReadOnly = true;
            this.dtgvPhieuNhap.RowTemplate.Height = 24;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(451, 164);
            this.dtgvPhieuNhap.TabIndex = 0;
            this.dtgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhieuNhap_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "NHẬP HÀNG VÀO KHO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChonLai);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.btnXoaSPLoi);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.txtNCC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(451, 91);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnChonLai
            // 
            this.btnChonLai.Location = new System.Drawing.Point(367, 49);
            this.btnChonLai.Name = "btnChonLai";
            this.btnChonLai.Size = new System.Drawing.Size(75, 28);
            this.btnChonLai.TabIndex = 5;
            this.btnChonLai.Text = "Chọn lại HD";
            this.btnChonLai.UseVisualStyleBackColor = true;
            this.btnChonLai.Click += new System.EventHandler(this.btnChonLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThanhToan.Location = new System.Drawing.Point(281, 49);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(80, 28);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoaSPLoi
            // 
            this.btnXoaSPLoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaSPLoi.Location = new System.Drawing.Point(365, 15);
            this.btnXoaSPLoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSPLoi.Name = "btnXoaSPLoi";
            this.btnXoaSPLoi.Size = new System.Drawing.Size(80, 28);
            this.btnXoaSPLoi.TabIndex = 4;
            this.btnXoaSPLoi.Text = "Xóa SP Lỗi";
            this.btnXoaSPLoi.UseVisualStyleBackColor = true;
            this.btnXoaSPLoi.Click += new System.EventHandler(this.btnXoaSPLoi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackgroundImage = global::DoanCNPM.Properties.Resources.iconfinder_print_printer_15001;
            this.btnInHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInHoaDon.Location = new System.Drawing.Point(281, 15);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(80, 28);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtNCC
            // 
            this.txtNCC.Enabled = false;
            this.txtNCC.Location = new System.Drawing.Point(60, 23);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(199, 20);
            this.txtNCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TÊN NCC:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoanCNPM.Properties.Resources.logo_n;
            this.pictureBox1.Location = new System.Drawing.Point(693, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rp);
            this.groupBox4.Location = new System.Drawing.Point(17, 314);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(902, 416);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hoá đơn nhập hàng";
            // 
            // rp
            // 
            this.rp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp.Location = new System.Drawing.Point(2, 15);
            this.rp.Margin = new System.Windows.Forms.Padding(2);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(898, 399);
            this.rp.TabIndex = 0;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(972, 725);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapKho";
            this.Text = "frmNhapKho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPHN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCTPHN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaSPLoi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChonLai;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer rp;
    }
}