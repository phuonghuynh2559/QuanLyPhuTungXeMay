using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Linq;
using DoanCNPM.DAL;

namespace DoanCNPM
{
    public partial class From_bán : DevExpress.XtraEditors.XtraForm
    {
        public static ListView lv;
        int idPhong = 0;
        public static int mahdd = 0;
        double sotiengiams = 0;
        string btnquaylai = "";
        
        public From_bán()
        {
            InitializeComponent();
        }

        private DataClassesTestDataContext db = new DataClassesTestDataContext();

        private void From_bán_Load(object sender, EventArgs e)
        {
            loadFrombt();
         
        }
        //Begin-Đây là nơi load ra các list danh sách sản phẩm 
        public void loadFrombt()
        {
            var q = db.LOAIPHUTUNGs;
            foreach (var l in q)
            {
                TabPage tp = new TabPage(l.TENPHUTUNG);
                tp.Name = l.MALOAI.ToString();
                tabControl1.Controls.Add(tp);
            }

            var minIDLoaiPhong = db.LOAIPHUTUNGs.Min(x => x.MALOAI);
            load(minIDLoaiPhong, 0);
        }
        //End-

        public void load(int loaiphong, int tabIndex)
        {
            lv = new ListView();
            lv.Dock = DockStyle.Fill;
            lv.SelectedIndexChanged += lv_SelectedIndexChanged;
            codexuly.LoadHinhTabPage();
            var sd = db.PHUTUNGXEs.Where(x => x.MALOAI == loaiphong );
          
            foreach (var pp in sd)
            {
                int kk = pp.MAPT - 1;
                lv.Items.Add(new ListViewItem { ImageIndex = kk, Text = pp.TENPT, Name = pp.MAPT.ToString() });
            }
            tabControl1.TabPages[tabIndex].Controls.Add(lv);
           
        }

        //Begin----Tìm kiếm sản phẩm
        public void timkiem()
        {
            try
            {
                var w = (from df in db.PHUTUNGXEs
                         where df.TENPT.StartsWith(txttimkiem.Text)
                         select new
                         {
                             maa = df.MALOAI
                         }).First();
                var qq = (from ltv in db.PHUTUNGXEs
                          where ltv.TENPT.StartsWith(txttimkiem.Text)
                         select ltv
                         ).ToList();

                var q = db.LOAIPHUTUNGs.Where(x => x.MALOAI == int.Parse(w.maa.ToString())).First();

                TabPage tp = new TabPage(q.TENPHUTUNG);
                tp.Name = q.MALOAI.ToString();
                tabControl1.Controls.Add(tp);

                lv = new ListView();
                lv.Dock = DockStyle.Fill;
                lv.SelectedIndexChanged += lv_SelectedIndexChanged;
                codexuly.LoadHinhTabPage();
                var sd = db.PHUTUNGXEs.Where(c => c.MAPT == int.Parse(w.maa.ToString()));

                foreach (var pp in qq)
                {
                    int kk = pp.MAPT - 1;
                    lv.Items.Add(new ListViewItem { ImageIndex = kk, Text = pp.TENPT, Name = pp.MAPT.ToString() });
                }
                tp.Controls.Add(lv);
            }
            catch
            {
                
                return;
            }
        }
        //End----Tìm kiếm sản phẩm


        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = lv.SelectedIndices;
            if (idx.Count > 0)
            {
                
                idPhong = int.Parse(lv.SelectedItems[0].Name);
                label1.Text = idPhong.ToString();
                var df = (from oo in db.PHUTUNGXEs
                         where oo.MAPT == idPhong
                         select new
                         {
                             ten = oo.MOTA,
                             tien = oo.GIABAN
                         }).First();
                txtten.Text = df.ten.ToString();
                txtten.Multiline = true;
                txtten.ScrollBars = ScrollBars.Both;
            
                lbgia.Text = df.tien.ToString();
                int kk = int.Parse(lbgia.Text);
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = true;
                int kj = (int)numericUpDown1.Value;
                int tt = kk * kj;
                lbthanhtien.Text = tt.ToString();
            }
        }

        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idphong = tabControl1.SelectedTab.Name;
            var tabIndex = tabControl1.SelectedIndex;
            numericUpDown1.Enabled = true;
            load(int.Parse(idphong), tabIndex);
        }

        //Begin---SDT chỉ cho nhập số 
        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //End---SDT chỉ cho nhập số 


        //Begin---button Tạo KH
        public void checkKH()
        {
            var q = db.KHACHHANGs.Where(x => x.SDT == txtNumberPhone.Text).ToList();

            if (q.Any())
            {
                lbCheckPhone.ForeColor = Color.Green;
                lbCheckPhone.Text = "Khách hàng đã có !";
                btnKH.Enabled = false;
                loadHD(txtNumberPhone.Text);
                gridControl2.Enabled = true;
                panel2.Enabled = true;
                return;

            }
            if (txtNumberPhone.Text == "")
            {
                lbCheckPhone.Text = "";
                btnKH.Enabled = false;
                gridControl2.Visible = true;
                loadHD("");
                return;
            }
            else
            {
                lbCheckPhone.ForeColor = Color.Red;
                lbCheckPhone.Text = "Khách hàng chưa có !";
                btnKH.Enabled = true;
                gridControl2.Visible = true;
                loadHD("");
                return;
            }
        }
        //End---Button tạo KH

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            checkKH();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tabControl1.Controls.Clear();
                if (txttimkiem.Text == "")
                {
                    loadFrombt();
                    return;
                }
                else
                {
                    timkiem();
                    return;
                }
            }
            catch
            {
                return;
            }
            
        }


        //Begin---Check giảm giá
        public bool checkgiamgia()
        {
            var k = from x in db.GIAMGIAs
                      where x.MAGIAMGIA == txtgiamgia.Text.ToUpper() && x.NGAYBATDAU <= DateTime.Now && x.NGAYKETTHUC >= DateTime.Now
                      select x;
            if (k.Any())
            {
                lbtb.ForeColor = Color.Green;
                lbtb.Text = "Mã giảm giá tồn tại !!!";
                 dd = k.Select(x => Convert.ToDouble(x.SOTIENGIAM)).First();
                return true;
            }
            else
            {
                lbtb.ForeColor = Color.Red;
                lbtb.Text = "Mã giảm giá khồng còn !";
                return false;
            }

        }

        double dd = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
                if (txtgiamgia.Text == "" || checkgiamgia() == false)
                {
                    int a = (int)numericUpDown1.Value;
                    int b = int.Parse(lbgia.Text);
                    int kq = a * b;
                    lbthanhtien.Text = kq.ToString();
                }
                if (checkgiamgia() == true)
                {
                    int a = (int)numericUpDown1.Value;
                    int b = int.Parse(lbgia.Text);
                    double c = double.Parse(dd.ToString());
                    double kq = (a * b) - c;
                    lbthanhtien.Text = kq.ToString();
                }
        }

        //Begin---Load Hoá Đơn đã có hoặc chưa có
        public void loadhoadon(int mahd,string sdt)
        {
            var hds = from hd in db.CTHDs
                      join pt in db.PHUTUNGXEs on hd.MAPT equals pt.MAPT
                      join kh in db.HOADONs on hd.MAHD equals kh.MAHD
                      where hd.MAHD == mahd && kh.SDT == sdt && pt.MAPT == hd.MAPT
                      select new
                      {
                          mhd = hd.MAHD,
                          ten = pt.TENPT,
                          soluong = hd.SOLUONG,
                          don = hd.DONGIA,
                          giam = hd.GIAMGIA,
                          thanhtien = hd.THANHTIEN
                      };
            gridControl1.DataSource = hds;
        }
        //End---Load Hoá Đơn đã có hoặc chưa có

        public void loadHD(string sdts)
        {
            var t = from j in db.HOADONs
                     where j.SDT == sdts
                     select j;
            gridControl2.DataSource = t;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            maql = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ten").ToString();
      
        }

        private void gridControl2_Click_1(object sender, EventArgs e)
        {
           mahdd = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHD").ToString().Trim());

        }

        private void txtgiamgia_EditValueChanged(object sender, EventArgs e)
        {
            checkgiamgia();
        }


        string maql = "";
        private void quaylai_Click(object sender, EventArgs e)
        {
            gridControl2.Visible = true;
            loadHD(txtNumberPhone.Text);
            quaylai.Enabled = false;
            quayxuong.Visible = true;
            maql = "";
 

        }

        //Begin---Button Đặt Hàng
        private void btndathang_Click(object sender, EventArgs e)
        {
            if (txtNumberPhone.Text == "" || lbgia.Text == "" || lbthanhtien.Text == "")
            {
                MessageBox.Show("Bạn không được để trống thông tin!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn lấy mã hóa đơn đã có rồi không !", "THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (r == DialogResult.Yes)
            {
                if (mahdd != 0)
                {
                    themHDroi();
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn cần chọn một hóa đơn để thêm !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (r == DialogResult.No)
            {
                themHD();

            }
        }
        //End---Button Đặt Hàng


        //Kiểm tra giảm giá
        public bool KiemTraGiamGia()
        {
            var giamgias = from x in db.GIAMGIAs
                           where x.MAGIAMGIA == txtgiamgia.Text.ToUpper() && x.NGAYBATDAU <= DateTime.Now && x.NGAYKETTHUC >= DateTime.Now
                           select x;
            if (giamgias.Any())
            {
                lbtb.ForeColor = Color.Green;
                lbtb.Text = "Mã giãm giá tồn tại !!!";
                sotiengiams = giamgias.Select(x => Convert.ToDouble(x.SOTIENGIAM)).First();
                return true;
            }
            else
            {
                lbtb.ForeColor = Color.Red;
                lbtb.Text = "Mã giảm giá khồng còn !";
                return false;
            }
        }
        public void themHD()
        {
            string txtSDT = txtNumberPhone.Text;
            if (codexuly.kiemtraSDTKH(txtSDT))
            {
                HOADON hd = new HOADON();
                hd.SDT = txtSDT;
                hd.MANV = Form1.nvdn.MANV;
                hd.NGAYBAN = DateTime.Now;
                hd.TONGTIEN = int.Parse(lbthanhtien.Text);
                hd.Tinhtrang = true;
                db.HOADONs.InsertOnSubmit(hd);
                db.SubmitChanges();

                //lấy hóa đơn để thêm vào chi tiết hóa đơn
                var hoadons = (from ll in db.HOADONs
                               orderby ll.MAHD descending
                               select new
                               {
                                   ma = ll.MAHD
                               }).First();
                CTHD ct = new CTHD();
                ct.MAHD = int.Parse(hoadons.ma.ToString());
                ct.MAPT = int.Parse(label1.Text);
                ct.SOLUONG = (int)numericUpDown1.Value;
                ct.DONGIA = int.Parse(lbgia.Text);
                if (KiemTraGiamGia() == true)
                {
                    ct.GIAMGIA = double.Parse(sotiengiams.ToString());
                }
                else
                {
                    ct.GIAMGIA = 0;
                }
                ct.THANHTIEN = int.Parse(lbthanhtien.Text);
                db.CTHDs.InsertOnSubmit(ct);
                db.SubmitChanges();
                loadHD(txtNumberPhone.Text);
                MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {

                MessageBox.Show("Số Điện thoại khách hàng chưa có trong hệ thống. Vui lòng thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }
        
        public void themHDroi()
        {
            CTHD ct = new CTHD();
            ct.MAHD = mahdd;
            ct.MAPT = int.Parse(label1.Text);
            ct.SOLUONG = (int)numericUpDown1.Value;
            ct.DONGIA = int.Parse(lbgia.Text);
            if (KiemTraGiamGia() == true)
            {
                ct.GIAMGIA = double.Parse(sotiengiams.ToString());
            }
            else
            {
                ct.GIAMGIA = 0;
            }
            ct.THANHTIEN = int.Parse(lbthanhtien.Text);
            db.CTHDs.InsertOnSubmit(ct);
            db.SubmitChanges();
            loadHD(txtNumberPhone.Text);
            MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loadhoadon(mahdd, txtNumberPhone.Text);
            quaylai.Enabled = true;
            gridControl2.Visible = false;
            quayxuong.Visible = false;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }
        
        //Xoá đơn hàng khi đơn hàng chưa có bảo hành 1 lần nào
        private void btnxoa_Click(object sender, EventArgs e)
        {
            #region xoa
            if (maql != "")
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xóa đơn hàng này không !", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (r == DialogResult.Yes)
                {

                var dff = (from kk in db.PHUTUNGXEs
                          where kk.TENPT == maql
                          select new 
                          {
                              ma = kk.MAPT
                          }).First();
                

                mahdd = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHD").ToString().Trim());

                CTHD knews = db.CTHDs.Where(x => x.MAHD == mahdd && x.MAPT == int.Parse(dff.ma.ToString())).Single();
                db.CTHDs.DeleteOnSubmit(knews);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông Báo");
                loadhoadon(mahdd, txtNumberPhone.Text);
                loadHD(txtNumberPhone.Text);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông Báo");
                    return;
                }
            }
                //Lưu ý : Một khi sản phẩm đã dc bảo hành thì ko thể xoá 
            else if (maql == "")
            {
                 var baohanhs = db.BAOHANHs.Where(x => x.MAHD == mahdd).Count();
               
                DialogResult r = MessageBox.Show("Bạn có muốn xóa đơn hàng này không !", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (r == DialogResult.Yes)
                {

                    mahdd = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHD").ToString().Trim());

                    
                    var kk = db.CTHDs.Where(x => x.MAHD == mahdd).Count();


                    if (int.Parse(kk.ToString()) == 0)
                    {
                        if (int.Parse(baohanhs.ToString()) > 0)
                        {
                            MessageBox.Show("KHông thể xóa vì sản phẩm đã nhận bảo hành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            HOADON knew = db.HOADONs.Where(x => x.MAHD == mahdd).First();
                            db.HOADONs.DeleteOnSubmit(knew);
                            db.SubmitChanges();
                            loadhoadon(mahdd, txtNumberPhone.Text);
                            loadHD(txtNumberPhone.Text);
                            MessageBox.Show("Xóa thành công!", "Thông Báo");
                        }
                    }
                    else if (int.Parse(kk.ToString()) > 0)
                    {
                       
                        if (int.Parse(baohanhs.ToString()) > 0)
                        {
                            MessageBox.Show("KHông thể xóa vì sản phẩm đã nhận bảo hành", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            for (int i = 1; i <= kk; i++)
                            {

                                var nhoc = (from l in db.CTHDs
                                            where l.MAHD == mahdd
                                            orderby l.MAHD descending
                                            select new
                                            {
                                                ma = l.MAPT
                                            }).First();

                                CTHD knews = db.CTHDs.Where(x => x.MAHD == mahdd && x.MAPT == int.Parse(nhoc.ma.ToString())).FirstOrDefault();
                                db.CTHDs.DeleteOnSubmit(knews);
                                db.SubmitChanges();

                            }
                            HOADON knew = db.HOADONs.Where(x => x.MAHD == mahdd).First();
                            db.HOADONs.DeleteOnSubmit(knew);
                            db.Refresh(RefreshMode.OverwriteCurrentValues, knew);
                            db.SubmitChanges();
                            loadhoadon(mahdd, txtNumberPhone.Text);
                            loadHD(txtNumberPhone.Text);
                            MessageBox.Show("Xóa thành công!", "Thông Báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông Báo");
                        return;
                    }
                }
            }
            #endregion


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnKH_Click(object sender, EventArgs e)
        {
            
            
            txtNumberPhone.Text = From_Khachhang.makh;
            From_Khachhang fr = new From_Khachhang();
            fr.Show();
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //DanhSachYT fr = new DanhSachYT();
            //fr.ShowDialog();
            //this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_BH fr = new Form_BH();
            fr.ShowDialog();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            Menu fr = new Menu();
            fr.ShowDialog();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private class OrderPlaced
        {
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           
        }
    }
}