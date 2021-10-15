namespace DoanCNPM
{
    partial class DuyetHang
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
            this.tdoNu = new System.Windows.Forms.RadioButton();
            this.rdonam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTinhtrang = new System.Windows.Forms.ComboBox();
            this.dataGridViewGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaGio = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnKtra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Diachi = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tdoNu);
            this.groupBox1.Controls.Add(this.rdonam);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXoaGio);
            this.groupBox1.Controls.Add(this.btnDatHang);
            this.groupBox1.Controls.Add(this.btnKtra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Diachi);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 443);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tdoNu
            // 
            this.tdoNu.AutoSize = true;
            this.tdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdoNu.Location = new System.Drawing.Point(201, 206);
            this.tdoNu.Name = "tdoNu";
            this.tdoNu.Size = new System.Drawing.Size(46, 21);
            this.tdoNu.TabIndex = 3;
            this.tdoNu.TabStop = true;
            this.tdoNu.Text = "Nữ";
            this.tdoNu.UseVisualStyleBackColor = true;
            // 
            // rdonam
            // 
            this.rdonam.AutoSize = true;
            this.rdonam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdonam.Location = new System.Drawing.Point(110, 206);
            this.rdonam.Name = "rdonam";
            this.rdonam.Size = new System.Drawing.Size(58, 21);
            this.rdonam.TabIndex = 3;
            this.rdonam.TabStop = true;
            this.rdonam.Text = "Nam";
            this.rdonam.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTinhtrang);
            this.groupBox2.Controls.Add(this.dataGridViewGioHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(281, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HÓA ĐƠN ĐẶT HÀNG";
            // 
            // comboTinhtrang
            // 
            this.comboTinhtrang.FormattingEnabled = true;
            this.comboTinhtrang.Location = new System.Drawing.Point(130, 19);
            this.comboTinhtrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTinhtrang.Name = "comboTinhtrang";
            this.comboTinhtrang.Size = new System.Drawing.Size(212, 21);
            this.comboTinhtrang.TabIndex = 5;
            this.comboTinhtrang.SelectedIndexChanged += new System.EventHandler(this.comboTinhtrang_SelectedIndexChanged);
            // 
            // dataGridViewGioHang
            // 
            this.dataGridViewGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.cl4,
            this.Column4});
            this.dataGridViewGioHang.Location = new System.Drawing.Point(6, 77);
            this.dataGridViewGioHang.Name = "dataGridViewGioHang";
            this.dataGridViewGioHang.Size = new System.Drawing.Size(673, 220);
            this.dataGridViewGioHang.TabIndex = 4;
            this.dataGridViewGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGioHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "SDT";
            this.Column2.HeaderText = "Số Điện Thoại";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MANV";
            this.Column5.HeaderText = "Mã Nhân Viên";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYBAN";
            this.Column3.HeaderText = "Ngày Lập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // cl4
            // 
            this.cl4.DataPropertyName = "TONGTIEN";
            this.cl4.HeaderText = "Tổng Tiền";
            this.cl4.Name = "cl4";
            this.cl4.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tinhtrang";
            this.Column4.HeaderText = "Tình Trạng";
            this.Column4.Name = "Column4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tình trạng đơn hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(759, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaGio
            // 
            this.btnXoaGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGio.Location = new System.Drawing.Point(552, 356);
            this.btnXoaGio.Name = "btnXoaGio";
            this.btnXoaGio.Size = new System.Drawing.Size(201, 44);
            this.btnXoaGio.TabIndex = 2;
            this.btnXoaGio.Text = "Xóa Đơn Hàng";
            this.btnXoaGio.UseVisualStyleBackColor = true;
            this.btnXoaGio.Click += new System.EventHandler(this.btnXoaGio_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Location = new System.Drawing.Point(345, 356);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(201, 44);
            this.btnDatHang.TabIndex = 2;
            this.btnDatHang.Text = "Duyệt đơn hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnKtra
            // 
            this.btnKtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKtra.Location = new System.Drawing.Point(73, 356);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(266, 44);
            this.btnKtra.TabIndex = 2;
            this.btnKtra.Text = "Cập nhật thông tin Khách Hàng";
            this.btnKtra.UseVisualStyleBackColor = true;
            this.btnKtra.Click += new System.EventHandler(this.btnKtra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điện thoại";
            // 
            // Diachi
            // 
            this.Diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diachi.Location = new System.Drawing.Point(113, 270);
            this.Diachi.Name = "Diachi";
            this.Diachi.Size = new System.Drawing.Size(162, 23);
            this.Diachi.TabIndex = 0;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(113, 126);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(162, 23);
            this.txtHoten.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(113, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 23);
            this.txtSDT.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label6.Location = new System.Drawing.Point(393, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 46);
            this.label6.TabIndex = 25;
            this.label6.Text = "DUYỆT ĐƠN HÀNG";
            // 
            // DuyetHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DuyetHang";
            this.Text = "DuyetHang";
            this.Load += new System.EventHandler(this.DuyetHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tdoNu;
        private System.Windows.Forms.RadioButton rdonam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaGio;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Diachi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox comboTinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;

    }
}