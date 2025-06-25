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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet Database = new CoSoDuLieuTiemNet();
        void layDuLieuHoaDon()
        {
            dataGridView1.DataSource = Database.HoaDons.ToList<HoaDon>();
        }
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            layDuLieuHoaDon();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        private int TinhTong()
        {
            int Tong = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                Tong += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            return Tong;
        }
        private void rdbt_thangnay_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbt_toanbo_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.HoaDons.ToList<HoaDon>();
            lb_tong.Text = TinhTong().ToString("N0");
        }

        private void rdbt_time_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbt_time.Checked)
            {
                DateTime tungay = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);
                DateTime denngay = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);
                dataGridView1.DataSource = Database.HoaDons.ToList<HoaDon>().FindAll(v => v.GioRa.Date >= tungay && v.GioRa.Date <= denngay);
                lb_tong.Text = TinhTong().ToString("N0");
            }
        }

        private void rdbt_thangnay_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.HoaDons.ToList<HoaDon>().FindAll(v => v.GioVao.Month == DateTime.Now.Month);
            lb_tong.Text = TinhTong().ToString("N0");
        }
    }
}
