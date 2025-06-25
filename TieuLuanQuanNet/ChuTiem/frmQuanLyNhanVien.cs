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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
        void layThongTinNhanVien()
        {
            dataGridView1.DataSource = coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>();
        }        
            
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTIEMNETDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLTIEMNETDataSet.NhanVien);
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            layThongTinNhanVien();
            dataGridView1.Columns[10].Visible = false;
        }

        bool KTTHEM()
        {
            if (txtMaNhanVien.Text == "" || txtHoTen.Text == "" || txtSoDienThoai.Text == "" || txtEmail.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            if (cbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng điền chức vụ");
                cbChucVu.Focus();
                return false;
            }
            else
            {
                if (cbChucVu.Text == "Nhân Viên Máy")
                {
                    if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" )
                    {
                        MessageBox.Show("Nhân viên máy cần điền tài khoản và mật khẩu");
                        txtTaiKhoan.Enabled = txtMatKhau.Enabled = true;
                        return false;
                    }
                }
                if (cbChucVu.Text == "Nhân Viên Bàn")
                {
                    if (txtTaiKhoan.Text != "" || txtMatKhau.Text != "")
                    {
                        MessageBox.Show("Nhân viên bàn không được điền tài khoản và mật khẩu");
                        txtTaiKhoan.Text = txtMatKhau.Text = "";
                        txtTaiKhoan.Enabled = txtMatKhau.Enabled = false;
                        return false;
                    }
                }
            }

            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 18)
            {
                MessageBox.Show("Nhân viên phải trên 18 tuổi");
                dtpNgaySinh.Focus();
                return false;
            }
            return true;
        }
        NhanVien nv;     
        bool check = true;     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
                return;
            }
            
            int ms = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (ms == 1)
            {
                MessageBox.Show("Không được xóa chủ tiệm");
                return;
            }
            DialogResult rs = MessageBox.Show($"Bạn có chắc xóa nhân viên '{ms}' không?", "Cảnh báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);          
            if (rs == DialogResult.No) return;
            nv = coSoDuLieuTiemNet.NhanViens.FirstOrDefault(n => n.MaNhanVien == ms);
            coSoDuLieuTiemNet.NhanViens.Remove(nv);
            coSoDuLieuTiemNet.SaveChanges();
            layThongTinNhanVien();
            MessageBox.Show($"Đã xóa nhân viên {ms} thành công");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (check)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
                    return;
                }
                else
                {                   
                    int ms = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    if (ms == 1)
                    {
                        MessageBox.Show("Không được sửa chủ tiệm");
                        return;
                    }
                    button1.Text = "Lưu sửa";
                    nv = coSoDuLieuTiemNet.NhanViens.FirstOrDefault(n => n.MaNhanVien == ms);
                    txtMaNhanVien.Text = nv.MaNhanVien.ToString();
                    txtHoTen.Text = nv.HoTen;
                    txtSoDienThoai.Text = nv.SoDienThoai;
                    txtEmail.Text = nv.Email;
                    cbChucVu.Text = nv.ChucVu;
                    dtpNgaySinh.Value = (DateTime)nv.NgaySinh;
                    txtTaiKhoan.Text = nv.TaiKhoan;
                    txtMatKhau.Text = nv.MatKhau;
                    comboBox1.Text = nv.Trangthai.ToString();
                }
                check = false;
            }
            else
            {
                if (int.Parse(txtMaNhanVien.Text) != nv.MaNhanVien)
                {
                    MessageBox.Show("Vui lòng không sửa mã nhân viên");
                    txtMaNhanVien.Text = nv.MaNhanVien.ToString();
                    return;
                }
                if (!KTTHEM()) return;
                nv = new NhanVien();
                nv.MaNhanVien = int.Parse(txtMaNhanVien.Text);
                nv.HoTen = txtHoTen.Text;
                nv.SoDienThoai = txtSoDienThoai.Text;
                nv.Email = txtEmail.Text;
                nv.ChucVu = cbChucVu.Text;
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.TaiKhoan = txtTaiKhoan.Text;
                nv.MatKhau = ThuVien.MD5Hash(txtMatKhau.Text);
                nv.Trangthai = int.Parse(comboBox1.Text);
                nv.CapBac = int.Parse(comboBox2.Text);
                coSoDuLieuTiemNet.NhanViens.AddOrUpdate(nv);
                coSoDuLieuTiemNet.SaveChanges();
                layThongTinNhanVien();
                MessageBox.Show("Đã sửa nhân viên thành công");
                check = true;
                txtMaNhanVien.Text = txtHoTen.Text = txtSoDienThoai.Text
                = txtEmail.Text = cbChucVu.Text = dtpNgaySinh.Text
                = txtTaiKhoan.Text = txtMatKhau.Text = comboBox1.Text = "";
                button1.Text = "Sửa";

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {           
            if (!KTTHEM()) return;
            foreach (var ms in coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>())
            {
                if (int.Parse(txtMaNhanVien.Text) == ms.MaNhanVien)
                {
                    MessageBox.Show("Mã nhân viên đã bị trùng, vui lòng nhập mã khác");
                    txtMaNhanVien.Focus();
                    return;
                }
            }
            nv = new NhanVien();
            nv.MaNhanVien = int.Parse(txtMaNhanVien.Text);
            nv.HoTen = txtHoTen.Text;
            nv.SoDienThoai = txtSoDienThoai.Text;
            nv.Email = txtEmail.Text;
            nv.ChucVu = cbChucVu.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = ThuVien.MD5Hash(txtMatKhau.Text);
            nv.Trangthai = int.Parse(comboBox1.Text);
            nv.CapBac = int.Parse(comboBox2.Text);
            coSoDuLieuTiemNet.NhanViens.AddOrUpdate(nv);
            coSoDuLieuTiemNet.SaveChanges();
            layThongTinNhanVien();
            MessageBox.Show("Đã thêm nhân viên thành công");
            txtMaNhanVien.Text = txtHoTen.Text = txtSoDienThoai.Text
                = txtEmail.Text = cbChucVu.Text = dtpNgaySinh.Text
                = txtTaiKhoan.Text = txtMatKhau.Text = comboBox1.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
