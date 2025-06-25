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
    public partial class frmSuaCauHinh : Form
    {
        public frmSuaCauHinh()
        {
            InitializeComponent();
        }
        public string ms;
        CoSoDuLieuTiemNet csdl = new CoSoDuLieuTiemNet();

        void layDuLieuRaTextBox()
        {
            CauHinhMayTinh chmt;
            chmt = csdl.CauHinhMayTinhs.FirstOrDefault(m => m.CauHinh == ms);
            txtCPU.Text = chmt.CPU;
            txtRAM.Text = chmt.RAM;
            txtOCung.Text = chmt.HardDrive;
            txtHDH.Text = chmt.OperatingSystem;
        }

        private void frmSuaCauHinh_Load(object sender, EventArgs e)
        {
            layDuLieuRaTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCPU.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập CPU!");
                txtCPU.Focus();
                return;
            }
            if (txtRAM.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn RAM!");
                txtRAM.Focus();
                return;
            }
            if (txtOCung.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn ổ cứng!");
                txtOCung.Focus();
                return;
            }
            if (txtHDH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hệ điều hành!");
                txtHDH.Focus();
                return;
            }
            CauHinhMayTinh chmt = new CauHinhMayTinh();
            chmt = csdl.CauHinhMayTinhs.FirstOrDefault(m => m.CauHinh == ms);
            chmt.CPU = txtCPU.Text;
            chmt.RAM = txtRAM.Text;
            chmt.HardDrive = txtOCung.Text;
            chmt.OperatingSystem = txtHDH.Text;
            csdl.CauHinhMayTinhs.AddOrUpdate(chmt);
            csdl.SaveChanges();
            MessageBox.Show("Đã sửa cấu hình thành công");
            this.Close();

        }
    }
}
