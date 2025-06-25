using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuanQuanNet
{
    public partial class frmGiaoDienNhanVien : Form
    {
        public frmGiaoDienNhanVien()
        {
            InitializeComponent();
        }

        private void btQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void btQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            (new frmDoiMatKhau()).ShowDialog();

        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            (new frmDangNhap()).ShowDialog();
            this.Close();
        }

        private void btThongKeNhanVien_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new frmMayChoThue()).ShowDialog();

        }
    }
}
