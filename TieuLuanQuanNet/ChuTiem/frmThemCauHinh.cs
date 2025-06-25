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
    public partial class frmThemCauHinh : Form
    {
        public frmThemCauHinh()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet csdl = new CoSoDuLieuTiemNet();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCauHinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập cấu hình!");
                txtCauHinh.Focus();
                return;
            }
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
            foreach (var ms in csdl.CauHinhMayTinhs.ToList<CauHinhMayTinh>())
            {
                if (txtCauHinh.Text == ms.CauHinh)
                {
                    MessageBox.Show("Cấu hình máy đã bị trùng, vui lòng nhập cấu hình khác");
                    txtCauHinh.Focus();
                    return;
                }
            }
            chmt.CauHinh = txtCauHinh.Text;
            chmt.CPU = txtCPU.Text;
            chmt.RAM = txtRAM.Text;
            chmt.HardDrive = txtOCung.Text;
            chmt.OperatingSystem = txtHDH.Text;
            csdl.CauHinhMayTinhs.AddOrUpdate(chmt);
            csdl.SaveChanges();
            txtCauHinh.Text = txtCPU.Text = txtRAM.Text = txtOCung.Text = txtHDH.Text = "";
            txtCauHinh.Focus();
            MessageBox.Show("Đã thêm cấu hình thành công");
        }
    }
}
