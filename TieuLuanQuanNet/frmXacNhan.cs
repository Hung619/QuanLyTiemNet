using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieuLuanQuanNet
{
    public partial class frmXacNhan : Form
    {
        public frmXacNhan()
        {
            InitializeComponent();
        }
        public static string xacnhan = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($" Xác nhận thanh toán hóa đơn", "Xác nhận thanh toán",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
            xacnhan = "1";
            this.Close();
        }
        public string ThoiGianSuDung
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string tienDichvu
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string tongtien
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string tiengio
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xacnhan = "";
            this.Close();
        }

        private void frmXacNhan_Load(object sender, EventArgs e)
        {
            xacnhan = "";
        }
    }
}
