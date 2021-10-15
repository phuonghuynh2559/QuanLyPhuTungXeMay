using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoanCNPM.DAL;

namespace DoanCNPM
{
    public partial class QL_NhapHang : Form
    {
        public static QL_NhapHang instance;
        public TextBox tb;
        public QL_NhapHang()
        {
            InitializeComponent();
            instance = this;
            tb = txtmahdn;
        }
        DataClassesTestDataContext dt = new DataClassesTestDataContext();
        public int layMaNCC()
        {
            string a = txtTenNCC.Text;
            var ma = dt.NHACUNGCAPs.Where(r => r.TENNCC.Equals(a)).First();
            return ma.MANCC;

        }
        private void QL_NhapHang_Load(object sender, EventArgs e)
        {
            loadNCC();
            loadPNH();
            dtpkNgaynhap.Value = DateTime.Now;
        }
        public void loadPNH()
        {
            var rs = from a in dt.PHIEUNHAPHANGs where a.TINHTRANG == false select a;
            dgvhoadonnhap.DataSource = rs;
            dgvhoadonnhap.Columns[1].Visible = false;
            dgvhoadonnhap.Columns[6].Visible = false;
            dgvhoadonnhap.Columns[7].Visible = false;
        }
        private void loadNCC()
        {
            var rs = from a in dt.NHACUNGCAPs select a;
            dgv_dsncc.DataSource = rs;
        }
        private void dgvhoadonnhap_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANG a = dgvhoadonnhap.CurrentRow.DataBoundItem as PHIEUNHAPHANG;
            var maNCC = dt.NHACUNGCAPs.Where(r => r.MANCC.Equals(a.MANCC)).SingleOrDefault();
            txtmahdn.Text = a.MANH.ToString();
            txtTenNCC.Text = maNCC.TENNCC;
            txtTongTien.Text = a.TONGTIEN.ToString();
            dtpkNgaynhap.Value = (DateTime)a.NGAYNHAP;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btTimkiem_Click_1(object sender, EventArgs e)
        {
            var qr = from d in dt.NHACUNGCAPs
                     where d.TENNCC.Contains(txtten.Text)
                     select d;
            if (qr.Count() == 0)
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            else
                dgv_dsncc.DataSource = qr.ToList();
            txtten.Text = "";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                PHIEUNHAPHANG a = new PHIEUNHAPHANG();
                var rs = dt.NHACUNGCAPs.Where(r => r.TENNCC.Equals(txtTenNCC.Text)).First();
                a.MANV = Form1.nvdn.MANV;
                a.MANCC = rs.MANCC;
                a.NGAYNHAP = DateTime.Now;
                a.TONGTIEN = 0;
                a.TINHTRANG = false;
                dt.PHIEUNHAPHANGs.InsertOnSubmit(a);
                dt.SubmitChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                loadPNH();
            }
            catch (Exception) { }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int maNH = int.Parse(txtmahdn.Text);
            PHIEUNHAPHANG ngayNH = dt.PHIEUNHAPHANGs.Where(r => r.MANH == maNH).First();
            DateTime ngay = DateTime.Parse(ngayNH.NGAYNHAP.ToString());
            int dSql = int.Parse(ngay.Day.ToString());
            int mSql = int.Parse(ngay.Month.ToString());
            int dNow = int.Parse(DateTime.Now.Day.ToString());
            int mNow = int.Parse(DateTime.Now.Month.ToString());
            if ((dNow - dSql > 3) || (mNow - mSql > 0))
            {
                MessageBox.Show("Không thể xóa hóa đơn nhập trên 3 ngày", "Thông báo");
            }
            else
            {
                List<CTNHAPHANG> ctn = dt.CTNHAPHANGs.Where(r => r.MANH == maNH).ToList();
                foreach (var list in ctn)
                {
                    dt.CTNHAPHANGs.DeleteOnSubmit(list);
                    dt.SubmitChanges();
                }
                PHIEUNHAPHANG pn = dt.PHIEUNHAPHANGs.Where(r => r.MANH == maNH).First();
                dt.PHIEUNHAPHANGs.DeleteOnSubmit(pn);
                dt.SubmitChanges();
                MessageBox.Show("Xóa Thành Công", "Thông báo");
                loadPNH();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (txtmahdn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nhập hàng", "Thông Báo");
            }
            else
            {
                this.Hide();
                ChiTietNhap fr = new ChiTietNhap();
                fr.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_dsncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NHACUNGCAP a = dgv_dsncc.CurrentRow.DataBoundItem as NHACUNGCAP;
            txtTenNCC.Text = a.TENNCC;
        }
    }
    }

