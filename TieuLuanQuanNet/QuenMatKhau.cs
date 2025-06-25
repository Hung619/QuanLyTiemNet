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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CoSoDuLieuTiemNet database = new CoSoDuLieuTiemNet();
            if (txt_tennguoidung.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đúng tên người dùng và email đã được Admin tạo!");
                return;
            }
            NhanVien user = database.NhanViens.FirstOrDefault(u => u.TaiKhoan == txt_tennguoidung.Text && u.Email == txt_email.Text);
            if (user != null)
            {
                Random random = new Random();
                int mk = random.Next(100001, 999999);

                user.MatKhau = ThuVien.MD5Hash(mk + "");
                database.NhanViens.AddOrUpdate(user);
                database.SaveChanges();
                if (ThuVien.SendEmail(user.Email, "Mật khẩu của bạn là: " + mk))
                {
                    MessageBox.Show("Mật khẩu đã được gửi đến email: " + user.Email);

                }
                else
                    MessageBox.Show("Sự cố gửi mail, vui lòng thử lại sau ít phút!");

            }
            else
            {
                MessageBox.Show("Tên người dùng/Email không đúng!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
