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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.Text = "Cửa Sổ Đăng Nhập";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        
        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_matkhau.PasswordChar = '*';

        }

        private void btDangNhap_Click_1(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Bạn đã đăng nhập sai quá số lần quy định, chương trình sẽ tự động thoát!");
                Application.Exit();
            }
            CoSoDuLieuTiemNet database = new CoSoDuLieuTiemNet();
            string matkhau = ThuVien.MD5Hash(txt_matkhau.Text);
            ThuVien.LoggedUser = database.NhanViens.FirstOrDefault(u => u.TaiKhoan == txt_taikhoan.Text && u.MatKhau == matkhau && u.Trangthai == 1);
            if (ThuVien.LoggedUser != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (ThuVien.LoggedUser.CapBac == 1)//chủ shop
                    (new frmGiaoDienChuTiem()).ShowDialog();
                else if (ThuVien.LoggedUser.CapBac == 2)//nhân viên
                    (new frmGiaoDienNhanVien()).ShowDialog();

            }
            else
            {
                count++;
                MessageBox.Show($"Thông tin đăng nhập không đúng hoặc tài khoản đã bị khóa!\nBạn đã đăng nhập sai {count} lần, còn {3 - count} lần!");

            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            QuenMatKhau f = new QuenMatKhau();
            f.ShowDialog();
        }

        private void chk_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienthi.Checked == true)
            {
                txt_matkhau.PasswordChar = (char)0;
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
        }
    }
}
