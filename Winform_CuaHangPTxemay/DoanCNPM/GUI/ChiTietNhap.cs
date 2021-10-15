using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoanCNPM.DAL;

namespace DoanCNPM
{
    public partial class ChiTietNhap : Form
    {
        public static ChiTietNhap instance;
        public ChiTietNhap()
        {
            InitializeComponent();
            instance = this;
            txtMahdn.Text = QL_NhapHang.instance.tb.Text;
        }
        DataClassesTestDataContext dt = new DataClassesTestDataContext();

        private void ChiTietNhap_Load(object sender, EventArgs e)
        {
            loadPhuTung();
            loadCTHDN();
        }
        public void loadPhuTung()
        {
            int a = QL_NhapHang.instance.layMaNCC();
            var rs = from pt in dt.PHUTUNGXEs where pt.MANCC.Equals(a) select pt;
            dgvXE.DataSource = rs;
            dgvXE.Columns[3].Visible = false;
            dgvXE.Columns[4].Visible = false;
            dgvXE.Columns[7].Visible = false;
            dgvXE.Columns[8].Visible = false;
            dgvXE.Columns[9].Visible = false;
            dgvXE.Columns[10].Visible = false;
            dgvXE.Columns[11].Visible = false;
        }
        public void loadCTHDN()
        {
            var rs = from a in dt.CTNHAPHANGs where a.MANH.Equals(int.Parse(txtMahdn.Text)) select a;
            dgvChitietHDN.DataSource = rs;
            dgvChitietHDN.Columns[4].Visible = false;
            dgvChitietHDN.Columns[5].Visible = false;
        }
        

        private void dgvChitietHDN_Click(object sender, EventArgs e)
        {
           
            
        }
        public int checkPhuTung()
        {
            PHUTUNGXE tenPT = dt.PHUTUNGXEs.Where(r => r.TENPT.Equals(txtTenPT.Text)).First();
            int a = int.Parse(txtMahdn.Text);
            var check = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(a) && r.MAPT.Equals(tenPT.MAPT)).Count();
            if (check > 0)
                return 1;
            return 0;
        }
        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtTenPT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phụ tùng cần nhập hàng", "Thông Báo");
            }
            else if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số phụ tùng cần nhập hàng", "Thông Báo");
            }
            else
            {
                try
                {
                    if (checkPhuTung() == 1)
                    {
                        DialogResult rs = MessageBox.Show("Phụ tùng đã có. Bạn muốn thêm số lượng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            PHUTUNGXE tenPT = dt.PHUTUNGXEs.Where(r => r.TENPT.Equals(txtTenPT.Text)).First();
                            int a = int.Parse(txtMahdn.Text);
                            CTNHAPHANG ctOld = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(a) && r.MAPT.Equals(tenPT.MAPT)).First();
                            CTNHAPHANG ctNew = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(ctOld.MANH) && r.MAPT.Equals(ctOld.MAPT)).First();
                            ctNew.SOLUONG = ctOld.SOLUONG + int.Parse(txtsoluong.Text);
                            int thanhTien = int.Parse(txtDongia.Text) * int.Parse(txtsoluong.Text);
                            ctNew.THANHTIEN = thanhTien + ctOld.THANHTIEN;
                            dt.SubmitChanges();
                            PHIEUNHAPHANG phieu = dt.PHIEUNHAPHANGs.Where(r => r.MANH.Equals(ctNew.MANH)).FirstOrDefault();
                            phieu.TONGTIEN = phieu.TONGTIEN + thanhTien;
                            dt.SubmitChanges();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            loadCTHDN();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        PHUTUNGXE a = dt.PHUTUNGXEs.Where(r => r.TENPT.Equals(txtTenPT.Text)).First();
                        CTNHAPHANG ct = new CTNHAPHANG();
                        ct.MANH = int.Parse(txtMahdn.Text);
                        ct.MAPT = a.MAPT;
                        ct.SOLUONG = int.Parse(txtsoluong.Text);
                        ct.THANHTIEN = a.GIABAN * ct.SOLUONG;
                        dt.CTNHAPHANGs.InsertOnSubmit(ct);
                        PHIEUNHAPHANG phieu = dt.PHIEUNHAPHANGs.Where(r => r.MANH.Equals(ct.MANH)).FirstOrDefault();
                        phieu.TONGTIEN = phieu.TONGTIEN + ct.THANHTIEN;
                        dt.SubmitChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        loadCTHDN();
                    }
                }
                catch (Exception) { }
            }
            
        }
        private void bttrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            QL_NhapHang fr = new QL_NhapHang(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fr.Show();
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMahdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CTNHAPHANG ctOld = dgvChitietHDN.CurrentRow.DataBoundItem as CTNHAPHANG;
                CTNHAPHANG ctNew = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(ctOld.MANH)).First();
                dt.CTNHAPHANGs.DeleteOnSubmit(ctNew);
                dt.SubmitChanges();
                PHIEUNHAPHANG phieu = dt.PHIEUNHAPHANGs.Where(r => r.MANH.Equals(ctNew.MANH)).First();
                phieu.TONGTIEN = phieu.TONGTIEN - ctNew.THANHTIEN;
                dt.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadCTHDN();
            }
            catch (Exception) { }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CTNHAPHANG ctOld = dgvChitietHDN.CurrentRow.DataBoundItem as CTNHAPHANG;
                CTNHAPHANG ctNew = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(ctOld.MANH)).First();
                ctNew.SOLUONG = int.Parse(txtsoluong.Text);
                int a = int.Parse(txtDongia.Text);
                ctNew.THANHTIEN = ctNew.SOLUONG * a;
                dt.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                loadCTHDN();
            }
            catch (Exception) { }
        }

        private void dgvChitietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CTNHAPHANG ct = dgvChitietHDN.CurrentRow.DataBoundItem as CTNHAPHANG;
            var maPT = dt.PHUTUNGXEs.Where(r => r.MAPT.Equals(ct.MAPT)).First();
            txtsoluong.Text = ct.SOLUONG.ToString();
            txtTenPT.Text = maPT.TENPT;
            txtDongia.Text = maPT.GIABAN.ToString();
        }

        private void dgvXE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PHUTUNGXE a = dgvXE.CurrentRow.DataBoundItem as PHUTUNGXE;
            txtTenPT.Text = a.TENPT;
            txtDongia.Text = a.GIABAN.ToString();
        }

    }
}
