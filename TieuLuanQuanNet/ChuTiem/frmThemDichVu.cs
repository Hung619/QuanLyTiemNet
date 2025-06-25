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
    public partial class frmThemDichVu : Form
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();

        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra nhập liệu
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã món!");
                txtID.Focus();
                return;
            }
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
            foreach (var ms in coSoDuLieuTiemNet.DichVus.ToList<DichVu>())
            {
                if (int.Parse(txtID.Text) == ms.MaDichVu)
                {
                    MessageBox.Show("Mã dịch vụ đã bị trùng, vui lòng nhập mã khác");
                    txtID.Focus();
                    return;
                }
            }
            dv.MaDichVu = int.Parse(txtID.Text);
            dv.Ten = txtName.Text;
            dv.DonViTinh = cbbUnit.Text;
            dv.Gia = int.Parse(txtPrice.Text);
            coSoDuLieuTiemNet.DichVus.AddOrUpdate(dv);
            coSoDuLieuTiemNet.SaveChanges();
            txtID.Text = txtName.Text = cbbUnit.ValueMember = txtPrice.Text = "";
            MessageBox.Show("Đã thêm món thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemDichVu_Load(object sender, EventArgs e)
        {

        }
    }
}
