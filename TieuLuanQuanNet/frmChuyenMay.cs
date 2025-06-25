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
    public partial class frmChuyenMay : Form
    {
        public frmChuyenMay()
        {
            InitializeComponent();
        }
        public static string ban = "";
        void HienThiBanTrong()
        {
            comboBox1.DataSource = frmMayChoThue.May.FindAll(t => t.TrangThai == 0);
            comboBox1.DisplayMember = "TenMay";
            comboBox1.ValueMember = "MaMayTram";
        }
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn cần chuyển đến!");
                comboBox1.Focus();
            }
            else
            {
                ban = comboBox1.SelectedValue.ToString();
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ban = "";
            this.Close();
        }

        private void frmChuyenMay_Load_1(object sender, EventArgs e)
        {
            HienThiBanTrong();
        }
    }
}
