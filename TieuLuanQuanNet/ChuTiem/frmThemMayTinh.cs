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
    public partial class frmThemMayTinh : Form
    {
        public frmThemMayTinh()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSTT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã máy!");
                txtSTT.Focus();
                return;
            }
            if (txtTenMay.Text.Trim() == "")
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
                MessageBox.Show("Vui lòng chọn trạng thái!");
                cbbTrangThai.Focus();
                return;
            }
            DanhSachMayTram dsmt = new DanhSachMayTram();  
            foreach(var ms in coSoDuLieuTiemNet.DanhSachMayTrams.ToList<DanhSachMayTram>())
            {
                if (int.Parse(txtSTT.Text) == ms.MaMayTram)
                {
                    MessageBox.Show("Mã máy đã bị trùng, vui lòng nhập mã khác");
                    txtSTT.Focus();
                    return;
                }
            }        
            dsmt.MaMayTram = int.Parse(txtSTT.Text);
            dsmt.TenMay = txtTenMay.Text;
            dsmt.CauHinh = cbbCauHinh.Text;
            dsmt.TrangThai = int.Parse(cbbTrangThai.Text);
            coSoDuLieuTiemNet.DanhSachMayTrams.AddOrUpdate(dsmt);
            coSoDuLieuTiemNet.SaveChanges();
            txtSTT.Text = txtTenMay.Text = cbbCauHinh.Text = cbbTrangThai.Text = "";
            MessageBox.Show("Đã thêm máy thành công");
        }

        private void frmThemMayTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTIEMNETDataSet1.CauHinhMayTinh' table. You can move, or remove it, as needed.
            this.cauHinhMayTinhTableAdapter.Fill(this.qLTIEMNETDataSet1.CauHinhMayTinh);

        }
    }
}
