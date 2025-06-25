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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet database = new CoSoDuLieuTiemNet();

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void cb_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cb_hienthimk.Checked;
            txt_mkcu.UseSystemPasswordChar = !isChecked;
            txt_mkmoi.UseSystemPasswordChar = !isChecked;
            txt_mkmoilan2.UseSystemPasswordChar = !isChecked;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doi_Click_1(object sender, EventArgs e)
        {
            if(txt_mkcu.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu cũ");
                return;
            }
            if (txt_mkmoi.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu mới");
                return;
            }
            if (txt_mkmoilan2.Text == "")
            {
                MessageBox.Show("Vui lòng điền xác nhận mật khẩu mới");
                return;
            }
            if (txt_mkmoi.Text != txt_mkmoilan2.Text)
            {
                MessageBox.Show("New password and confirmation do not match.");
                return;
            }
            string username = textBox1.Text;
            string matkhau = ThuVien.MD5Hash(txt_mkcu.Text);

            var user = database.NhanViens.SingleOrDefault(u => u.TaiKhoan == username && u.MatKhau == matkhau);
            if (user != null)
            {
                user.MatKhau = ThuVien.MD5Hash(txt_mkmoi.Text);
                database.NhanViens.AddOrUpdate(user);

                database.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công.");
                textBox1.Text = txt_mkcu.Text = txt_mkmoi.Text = txt_mkmoilan2.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.");
            }

        }        

        private void txt_mkcu_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txt_mkcu.UseSystemPasswordChar = !cb_hienthimk.Checked;
        }

        private void txt_mkmoi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txt_mkmoi.UseSystemPasswordChar = !cb_hienthimk.Checked;
        }

        private void txt_mkmoilan2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txt_mkmoilan2.UseSystemPasswordChar = !cb_hienthimk.Checked;
        }
    }
}
