using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TieuLuanQuanNet.Database;

namespace TieuLuanQuanNet
{
    public partial class frmQuanLyCauHinh : Form
    {
        public frmQuanLyCauHinh()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet csdl = new CoSoDuLieuTiemNet();
        
        void layThongTinCauHinh()
        {
            dgvMay.DataSource = csdl.CauHinhMayTinhs.ToList<CauHinhMayTinh>();
        }
        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            layThongTinCauHinh();
            dgvMay.Columns[5].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            csdl = new CoSoDuLieuTiemNet();
            layThongTinCauHinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new frmThemCauHinh()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvMay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn cấu hình cần xóa");
                return;
            }
            string ms = dgvMay.SelectedRows[0].Cells[0].Value.ToString();
            CauHinhMayTinh chmt = csdl.CauHinhMayTinhs.FirstOrDefault(m => m.CauHinh == ms);
            csdl.CauHinhMayTinhs.Remove(chmt);
            csdl.SaveChanges();
            MessageBox.Show("Đã xóa cấu hình thành công");
            layThongTinCauHinh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn cấu hình cần sửa");
                return;
            }
            frmSuaCauHinh sm = new frmSuaCauHinh();
            sm.ms = dgvMay.SelectedRows[0].Cells[0].Value.ToString();
            sm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
