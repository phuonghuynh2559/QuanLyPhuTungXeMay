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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace DoanCNPM
{
    public partial class frmNhapKho : Form
    {
        DataClassesTestDataContext dt = new DataClassesTestDataContext();
      
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            loadPhieuNhap();
            this.rp.RefreshReport();
        }
        public void loadPhieuNhap()
        {
            var result = from d in dt.PHIEUNHAPHANGs where d.TINHTRANG == false select d;
            dtgvPhieuNhap.DataSource = result;
            dtgvPhieuNhap.Columns[1].Visible = false;
            dtgvPhieuNhap.Columns[2].Visible = false;
            dtgvPhieuNhap.Columns[5].Visible = false;
            dtgvPhieuNhap.Columns[6].Visible = false;
            dtgvPhieuNhap.Columns[7].Visible = false;
            
        }
        public void loadPhieuNhap(int id)
        {
            var result = from d in dt.PHIEUNHAPHANGs where d.TINHTRANG == false && d.MANH == id select d;
            dtgvPhieuNhap.DataSource = result;
            dtgvPhieuNhap.Columns[1].Visible = false;
            dtgvPhieuNhap.Columns[2].Visible = false;
            dtgvPhieuNhap.Columns[5].Visible = false;
            dtgvPhieuNhap.Columns[6].Visible = false;
            dtgvPhieuNhap.Columns[7].Visible = false;
        }
        private void dtgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PHIEUNHAPHANG x = dtgvPhieuNhap.CurrentRow.DataBoundItem as PHIEUNHAPHANG;
            loadPhieuNhap(x.MANH);
            loadCTPN(x.MANH);
            NHACUNGCAP ncc = dt.NHACUNGCAPs.Where(r => r.MANCC.Equals(x.MANCC)).First();
            txtNCC.Text = ncc.TENNCC;
            dateTimePicker1.Value = DateTime.Parse(x.NGAYNHAP.ToString());
        }
        public void loadCTPN()
        {
            var ctpn = from d in dt.CTNHAPHANGs select d;
            dtgvCTPHN.DataSource = ctpn;
            dtgvCTPHN.Columns[4].Visible = false;
            dtgvCTPHN.Columns[5].Visible = false;
        }
        public void loadCTPN(int id)
        {
            var ctpn = from d in dt.CTNHAPHANGs where d.MANH.Equals(id) select d;
            dtgvCTPHN.DataSource = ctpn;
            dtgvCTPHN.Columns[4].Visible = false;
            dtgvCTPHN.Columns[5].Visible = false;
        }
        private void btnXoaSPLoi_Click(object sender, EventArgs e)
        {
            try
            {
                CTNHAPHANG x = dtgvCTPHN.CurrentRow.DataBoundItem as CTNHAPHANG;
                CTNHAPHANG ctDelete = dt.CTNHAPHANGs.Where(r => r.MANH.Equals(x.MANH)).First();
                dt.CTNHAPHANGs.DeleteOnSubmit(ctDelete);
                PHIEUNHAPHANG pnUpdate = dt.PHIEUNHAPHANGs.Where(r => r.MANH.Equals(ctDelete.MANH)).First();
                pnUpdate.TONGTIEN = pnUpdate.TONGTIEN - ctDelete.THANHTIEN;
                MessageBox.Show("Đã xóa sản phẩm lỗi và cập nhật lại hóa đơn.", "Thông báo");
                dt.SubmitChanges();
                loadPhieuNhap(pnUpdate.MANH);
                loadCTPN(pnUpdate.MANH);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm lỗi để xóa","Thông báo");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANG x = dtgvPhieuNhap.CurrentRow.DataBoundItem as PHIEUNHAPHANG;
            try
            {
                var ct = from d in dt.CTNHAPHANGs where d.MANH.Equals(x.MANH) select new { MAPT = d.MAPT, SOLUONG = d.SOLUONG };
                foreach (var i in ct)
                {
                    PHUTUNGXE ptOld = dt.PHUTUNGXEs.Where(r => r.MAPT.Equals(i.MAPT)).First();
                    PHUTUNGXE ptNew = dt.PHUTUNGXEs.Where(r => r.MAPT.Equals(ptOld.MAPT)).First();
                    ptNew.SOLUONG = ptOld.SOLUONG + i.SOLUONG;
                }
                PHIEUNHAPHANG phieuNew = dt.PHIEUNHAPHANGs.Where(r => r.MANH.Equals(x.MANH)).First();
                phieuNew.TINHTRANG = true;
                dt.SubmitChanges();
                MessageBox.Show("Thanh toán và nhập phụ tùng thành công", "Thông báo");
                loadPhieuNhap();
                this.dtgvCTPHN.DataSource = null;
                this.rp.LocalReport.DataSources.Clear();
                this.rp.RefreshReport();
            }
            catch (Exception) { }
        }

        private void btnChonLai_Click(object sender, EventArgs e)
        {
            loadPhieuNhap();
            this.dtgvCTPHN.DataSource = null;
            this.rp.LocalReport.DataSources.Clear();
            this.rp.RefreshReport();
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANG x = dtgvPhieuNhap.CurrentRow.DataBoundItem as PHIEUNHAPHANG;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QL_PHUTUNGConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "rpNH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@MANH",x.MANH));
            cmd.Parameters.Add(new SqlParameter("@NGAY", dateTimePicker1.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            rp.ProcessingMode = ProcessingMode.Local;
            rp.LocalReport.ReportPath = "Report2.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ds.Tables[0];
                rp.LocalReport.DataSources.Clear();
                rp.LocalReport.DataSources.Add(rds);
                rp.RefreshReport();
            }
            btnThanhToan.Enabled = true;
        }
    }
}
