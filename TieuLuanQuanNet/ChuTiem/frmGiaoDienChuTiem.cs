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
    public partial class frmGiaoDienChuTiem : Form
    {
        public frmGiaoDienChuTiem()
        {
            InitializeComponent();
        }

        private void btQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            (new frmQuanLyNhanVien()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new frmQuanlyDichVu()).ShowDialog();

        }

        private void btQuanLyMay_Click(object sender, EventArgs e)
        {
            (new frmQuanLyMayTinh()).ShowDialog();
        }

        private void btThongKeNhanVien_Click(object sender, EventArgs e)
        {
            (new frmThongKeNhanVien()).ShowDialog();

        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            (new frmThongKeDoanhThu()).ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new frmMayChoThue()).ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new frmDoiMatKhau()).ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new frmQuanLyCauHinh()).ShowDialog();
        }
    }
}
