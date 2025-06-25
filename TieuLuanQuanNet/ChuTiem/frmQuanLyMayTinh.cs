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
    public partial class frmQuanLyMayTinh : Form
    {
        public frmQuanLyMayTinh()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();

        void layDuLieuMayTinh()
        {
            dgvMay.DataSource = coSoDuLieuTiemNet.DanhSachMayTrams.ToList<DanhSachMayTram>();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            (new frmThemMayTinh()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn máy cần sửa");
                return;
            }
            frmSuaMay sm = new frmSuaMay();
            sm.ms = int.Parse(dgvMay.SelectedRows[0].Cells[0].Value.ToString());
            sm.ShowDialog();

        }

        private void frmQuanLyMayTinh_Load(object sender, EventArgs e)
        {
            layDuLieuMayTinh();
            dgvMay.Columns[4].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvMay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn máy cần xóa");
                return;
            }
            int ms = int.Parse(dgvMay.SelectedRows[0].Cells[0].Value.ToString());
            DanhSachMayTram dsmt = coSoDuLieuTiemNet.DanhSachMayTrams.FirstOrDefault(m => m.MaMayTram == ms);
            coSoDuLieuTiemNet.DanhSachMayTrams.Remove(dsmt);
            coSoDuLieuTiemNet.SaveChanges();
            MessageBox.Show("Đã xóa máy thành công");
            layDuLieuMayTinh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
            layDuLieuMayTinh();
        }
    }
}
