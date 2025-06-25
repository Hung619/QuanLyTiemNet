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
    public partial class frmQuanlyDichVu : Form
    {
        public frmQuanlyDichVu()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
        
        void layDuLieuDichVu()
        {
            dgvItems.DataSource = coSoDuLieuTiemNet.DichVus.ToList<DichVu>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new frmThemDichVu()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần sửa");
                return;
            }
            frmSuaDichVu sdv = new frmSuaDichVu();
            sdv.ms = int.Parse(dgvItems.SelectedRows[0].Cells[0].Value.ToString());
            sdv.ShowDialog();

        }

        private void frmQuanlyDichVu_Load(object sender, EventArgs e)
        {
            layDuLieuDichVu();
            dgvItems.Columns[4].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
            layDuLieuDichVu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa");
                return;
            }
            int ms = int.Parse(dgvItems.SelectedRows[0].Cells[0].Value.ToString());
            DichVu dv = coSoDuLieuTiemNet.DichVus.FirstOrDefault(m => m.MaDichVu == ms);
            coSoDuLieuTiemNet.DichVus.Remove(dv);
            coSoDuLieuTiemNet.SaveChanges();
            MessageBox.Show("Đã xóa món thành công");
            layDuLieuDichVu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
