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
    public partial class frmThongKeNhanVien : Form
    {
        public frmThongKeNhanVien()
        {
            InitializeComponent();
        }
        CoSoDuLieuTiemNet coSoDuLieuTiemNet = new CoSoDuLieuTiemNet();
        NhanVien nv = new NhanVien();
        void layThongTinNhanVien(int maNhanVien)
        {
            if (maNhanVien != 0)
            {
                dataGridView1.DataSource = coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>().FindAll(m => m.MaNhanVien == maNhanVien);
            }
            else
                dataGridView1.DataSource = coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>();

        }
        void timChucVu(string chucVu)
        {
            if (chucVu != "")
            {
                dataGridView1.DataSource = coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>().FindAll(m => m.ChucVu == chucVu);
            }
            
        }
        void timTrangThai(string trangThai)
        {
            if (trangThai != "")
            {
                dataGridView1.DataSource = coSoDuLieuTiemNet.NhanViens.ToList<NhanVien>().FindAll(m => m.Trangthai == int.Parse(trangThai));
            }
            
        }
        private void frmThongKeNhanVien_Load(object sender, EventArgs e)
        {
            layThongTinNhanVien(0);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.Columns[10].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if(textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào mã nhân viên cần tìm");
                return;
            }
            layThongTinNhanVien(int.Parse(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào chức vụ cần tìm");
                return;
            }
            timChucVu(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Vui lòng điền vào trạng thái cần tìm");
                return;
            }
            timTrangThai(comboBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
