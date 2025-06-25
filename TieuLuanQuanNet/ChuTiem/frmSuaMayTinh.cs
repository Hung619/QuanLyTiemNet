using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TieuLuanQuanNet.Database;

namespace TieuLuanQuanNet
{
    public partial class frmSuaMay : Form
    {
        public frmSuaMay()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
        public int ms;

        void layDuLieuRaTextBox()
        {
            DanhSachMayTram dsmt;
            dsmt = coSoDuLieuTiemNet.DanhSachMayTrams.FirstOrDefault(m => m.MaMayTram == ms);
            txtTenMay.Text = dsmt.TenMay;
            cbbCauHinh.Text = dsmt.CauHinh;
            cbbTrangThai.Text = dsmt.TrangThai.ToString();
        }
        private void frmSuaMay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTIEMNETDataSet1.CauHinhMayTinh' table. You can move, or remove it, as needed.
            this.cauHinhMayTinhTableAdapter.Fill(this.qLTIEMNETDataSet1.CauHinhMayTinh);
            layDuLieuRaTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTenMay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên máy!");
                txtTenMay.Focus();
                return;
            }
            if (cbbCauHinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn cấu hình!");
                cbbCauHinh.Focus();
                return;
            }
            if (cbbTrangThai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn cấu hình!");
                cbbTrangThai.Focus();
                return;
            }
            DanhSachMayTram dsmt = new DanhSachMayTram();
            dsmt = coSoDuLieuTiemNet.DanhSachMayTrams.FirstOrDefault(m => m.MaMayTram == ms);
            dsmt.TenMay = txtTenMay.Text;
            dsmt.CauHinh = cbbCauHinh.Text;
            dsmt.TrangThai = int.Parse(cbbTrangThai.Text);
            coSoDuLieuTiemNet.DanhSachMayTrams.AddOrUpdate(dsmt);
            coSoDuLieuTiemNet.SaveChanges();
            txtTenMay.Text = cbbCauHinh.Text = cbbTrangThai.Text = "";
            MessageBox.Show("Đã sửa máy thành công");
        }
    }
}
