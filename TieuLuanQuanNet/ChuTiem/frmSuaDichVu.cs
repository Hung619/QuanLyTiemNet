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
    public partial class frmSuaDichVu : Form
    {
        public frmSuaDichVu()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
        public int ms;

        void layDuLieuRaTextBox()
        {
            DichVu dv;
            dv = coSoDuLieuTiemNet.DichVus.FirstOrDefault(m => m.MaDichVu == ms);
            txtName.Text = dv.Ten;
            txtPrice.Text = dv.Gia.ToString();
            cbbUnit.Text = dv.DonViTinh;
        }
        private void frmSuaDichVu_Load(object sender, EventArgs e)
        {
            layDuLieuRaTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên món!");
                txtName.Focus();
                return;
            }
            if (cbbUnit.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập/chọn ĐV tính!");
                cbbUnit.Focus();
                return;
            }
            if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!");
                txtPrice.Focus();
                return;
            }
            if (int.Parse(txtPrice.Text.Trim()) <= 0)
            {
                MessageBox.Show("Đơn giá phải >0!");
                txtPrice.Focus();
                return;
            }
            DichVu dv = new DichVu();
            dv = coSoDuLieuTiemNet.DichVus.FirstOrDefault(m => m.MaDichVu == ms);
            dv.Ten = txtName.Text;
            dv.Gia = int.Parse(txtPrice.Text);
            dv.DonViTinh = cbbUnit.Text;
            coSoDuLieuTiemNet.DichVus.AddOrUpdate(dv);
            coSoDuLieuTiemNet.SaveChanges();
            txtName.Text = cbbUnit.ValueMember = txtPrice.Text = "";
            MessageBox.Show("Đã sửa món thành công");
        }
    }
}
