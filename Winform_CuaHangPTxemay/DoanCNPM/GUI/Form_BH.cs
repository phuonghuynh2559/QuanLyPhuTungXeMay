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
using DoanCNPM.DAL;

namespace DoanCNPM
{
    public partial class Form_BH : DevExpress.XtraEditors.XtraForm
    {
        public Form_BH()
        {
            InitializeComponent();
        }

        DataClassesTestDataContext db = new DataClassesTestDataContext();

        // Load ra sdt và mahd
        public void LoadTimKiem(string sdt, int ma)
        {
            var kk = from ll in db.PHUTUNGXEs
                     join ss in db.CTHDs on ll.MAPT equals ss.MAPT
                     join dds in db.HOADONs on ss.MAHD equals dds.MAHD
                     where dds.SDT == sdt && dds.MAHD == ma
                     select new
                     {
                         ll.MAPT,
                         ll.TENPT,
                         ss.SOLUONG,
                         dds.NGAYBAN
                     };

            timmm.Properties.DataSource = kk;
            timmm.Properties.DisplayMember = "MAPT";
            timmm.Properties.ValueMember = "MAPT";
        }

        //Đây là khi nhập sdt và mahd thì nó sẽ chạy hàm loadTimKiem
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textEdit1.Text != "")
                {
                    LoadTimKiem(textEdit2.Text.Trim(), int.Parse(textEdit1.Text.Trim()));
                    
                    return;
                }
                else
                {
                    LoadTimKiem(textEdit2.Text.Trim(), 0);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi r");
                return;
            }
        }
        string kcheckBox1 = "";
        string kcheckBox2 = "";
        string kcheckBox3 = "";
        string kcheckBox4 = "";
        //Re set các text
        public void chaylai()
        {
            textEdit1.ResetText();
            textEdit2.ResetText();
            numericUpDown1.Value = 0;
        }
        //Begin---Bảo Hành 
        //Lưu ý chỉ dc bảo hành 1 lần , nếu bảo hành lần 2 sẽ hiển thị thông báo thất bại
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEdit1.Text != "" && textEdit2.Text != "" && timmm.Text != "")
                {
                    int mahd = int.Parse(textEdit1.Text.Trim());
                    int mapt = int.Parse(timmm.Text.Trim());
                    var ngaybans = (from ll in db.PHUTUNGXEs
                                    join ss in db.CTHDs on ll.MAPT equals ss.MAPT
                                    join dds in db.HOADONs on ss.MAHD equals dds.MAHD
                                    where dds.SDT == textEdit2.Text.Trim() && dds.MAHD == int.Parse(textEdit1.Text.Trim()) && ss.MAPT == int.Parse(timmm.Text)
                                    select new
                                    {
                                        ngay = dds.NGAYBAN
                                    }).First();
                    string ngayhethongs = ngaybans.ngay.ToString();
                    DateTime ngayhethangBH = Convert.ToDateTime(ngayhethongs).AddDays(+1).AddHours(+24);

                    if (Convert.ToDateTime(ngayhethongs) < DateTime.Now && DateTime.Now <= ngayhethangBH && numericUpDown1.Value != 0)
                    {
                        var h = db.BAOHANHs.Where(x => x.MAHD == mahd && x.MAPT == mapt ).ToList();//&& x.SOLAN_DOI == 1
                        if (h.Any())
                        {
                            DialogResult r = MessageBox.Show("Bạn đã tồn tại một phiếu bảo hành rồi có muốn thực hiện bảo hành lại không", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                            if (r == DialogResult.Yes)
                            {
                                BAOHANH baohanhs = new BAOHANH();
                                baohanhs.MAHD = mahd;
                                baohanhs.MAPT = mapt;
                                baohanhs.MANV = Form1.nvdn.MANV;
                                //baohanhs.SOLAN_DOI = 2;
                                baohanhs.SOLUONG_DOI = (int)numericUpDown1.Value;
                                baohanhs.NGAYMUA = ngaybans.ngay;
                                baohanhs.NGAYTRA = DateTime.Now;
                                baohanhs.TINHTRANG = kcheckBox1 + kcheckBox2 + kcheckBox3 + kcheckBox4;
                                db.BAOHANHs.InsertOnSubmit(baohanhs);
                                db.SubmitChanges();
                                MessageBox.Show("Bảo hành thành công !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);
                                chaylai();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Kết thúc quá trình bảo hành ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            BAOHANH bh = new BAOHANH();
                            bh.MAHD = int.Parse(textEdit1.Text);
                            bh.MAPT = int.Parse(timmm.Text);
                            bh.MANV = Form1.nvdn.MANV;
                            //bh.SOLAN_DOI = 1;
                            bh.SOLUONG_DOI = (int)numericUpDown1.Value;
                            bh.NGAYMUA = ngaybans.ngay;
                            bh.NGAYTRA = DateTime.Now;
                            bh.TINHTRANG = kcheckBox1 + kcheckBox2 + kcheckBox3 + kcheckBox4;
                            db.BAOHANHs.InsertOnSubmit(bh);
                            db.SubmitChanges();
                            MessageBox.Show("Bảo hành thành công !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);
                            chaylai();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dịch vụ bảo hành thất bại do sản phẩm chỉ bảo hành trong ngày!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cần thực nhập đầy đủ thông tin !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch
            {
                MessageBox.Show("Kết thúc quá trình bảo hành vì không được bào hành quá 2 lần ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textEdit1.Text != "" && textEdit2.Text != "" && timmm.Text != "")
                {
                    var kk = (from ll in db.PHUTUNGXEs
                              join ss in db.CTHDs on ll.MAPT equals ss.MAPT
                              join dds in db.HOADONs on ss.MAHD equals dds.MAHD
                              where dds.SDT == textEdit2.Text.Trim() && dds.MAHD == int.Parse(textEdit1.Text.Trim()) && ss.MAPT == int.Parse(timmm.Text)
                              select new
                              {
                                  sl = ss.SOLUONG
                              }).First();

                    if (numericUpDown1.Value > kk.sl)
                    {
                        MessageBox.Show("Bạn không được nhập giá trị lớn hơn số lượng trong hóa đơn !!!!", "THÔNG BÁO");
                        numericUpDown1.Value = 0;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin ở trên");
                }
            }
            catch
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin ở trên");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kcheckBox1 = "Trầy xước";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            kcheckBox2 = "Không hoạt động ổn định";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            kcheckBox3 = "Hư hỏng";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            kcheckBox4 = "Vấn đề khác";
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            checkKH();
        }
        public void checkKH()
        {
            var q = db.KHACHHANGs.Where(x => x.SDT == textEdit2.Text).ToList();

            if (q.Any())
            {

                label1.ForeColor = Color.Green;
                label1.Text = "Khách hàng đã có !";
                return;

            }
            if (label1.Text == "")
            {
                label1.Text = "";
                return;
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Khách hàng chưa có !";
                return;
            }

        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số !!!!!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form_BH_Load(object sender, EventArgs e)
        {
            loadhd();
        }
        public void loadhd()
        {
            dataGridView1.DataSource = db.HOADONs.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}