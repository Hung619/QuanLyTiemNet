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
    public partial class frmMayChoThue : Form
    {

        public frmMayChoThue()
        {
            InitializeComponent();

        }
        CoSoDuLieuTiemNet csdl = new CoSoDuLieuTiemNet();
        public int ms;
        Database.DataHandLe DB = new Database.DataHandLe();
        public class may
        {
            public string TenMay { get; set; }
            public string CauHinh { get; set; }
            public int TrangThai { get; set; }
            public string MaMayTram { get; set; }
        }
        public static List<may> May = new List<may>();
        class chitiethoadon
        {
            public string MaDichVu { get; set; }
            public string Ten { get; set; }
            public int SoLuong { get; set; }
            public int DonViTinh { get; set; }
        }
        class hoadon
        {
            public string MaHoaDon { get; set; }
            public DateTime giovao { get; set; }
            public string MaMayTram { get; set; }
            public List<chitiethoadon> ChiTietHoaDon { get; set; } = new List<chitiethoadon>();
        }
        private static List<hoadon> HoaDon1 = new List<hoadon>();

        void XuatTimeLeft(DateTime date)
        {
            int TotalMinutes = (int)(DateTime.Now - date).TotalMinutes;
            lbThoiGianSuDung.Text = TotalMinutes / 60 + " giờ : " + (TotalMinutes % 60) + " phút";
        }
        void LayDuLieuMay()
        {
            if (May.Count > 0) return;
            DataTable data = DB.LayDuLieu("SELECT * FROM DanhSachMayTram");
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                    May.Add(new may()
                    {
                        TenMay = data.Rows[i]["TenMay"].ToString(),
                        CauHinh = data.Rows[i]["CauHinh"].ToString(),
                        TrangThai = int.Parse(data.Rows[i]["TrangThai"].ToString()),
                        MaMayTram = (data.Rows[i]["MaMayTram"].ToString())
                    });
            }
        }
        string idmay = "";
        private void lvMay_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lbMay.Text = e.Item.Text;
            //Kiểm tra máy tróng hay đã có hóa đơn
            idmay = May[e.Item.Index].MaMayTram;//Lấy số bàn
            if (e.Item.StateImageIndex == 0)//Bàn trống
            {
                btTaoHoaDon.Enabled = true;
                //xóa thông tin của bill khác
                dtpThoiGianVao.Value = DateTime.Now;
                dgvChiTietHoaDon.Rows.Clear();
                lbTongTien.Text = lbThoiGianSuDung.Text = cbbTenMon.Text = "";
            }
            else
            {
                btTaoHoaDon.Enabled = false;
                //Xuất ra thông tin hóa đơn cữ
                //tìm danh sách các bill đã lưu trước đó
                hoadon hoadon = HoaDon1.Find(b => b.MaMayTram == idmay);
                XuatTimeLeft(hoadon.giovao);
                //xuất ra thông tin bill đã lập trước đó
                if (hoadon != null) XuatThongTinHoaDonCu(hoadon);
            }
        }
        private void frmMayChoThue_Load(object sender, EventArgs e)
        {
            showListviewMay();
            LayDanhSachMon();
            cbbTenMon.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        DataTable dsMon = new DataTable();

        void LayDanhSachMon()
        {
            dsMon = DB.LayDuLieu("SELECT * FROM DichVu WHERE MaDichVu <> '0'");
            cbbTenMon.DataSource = dsMon;
            cbbTenMon.DisplayMember = "Ten";
            cbbTenMon.ValueMember = "MaDichVu";
            cbbTenMon.SelectedIndex = -1;
        }
        private void btChuyenMay_Click(object sender, EventArgs e)
        {
            if (idmay == "")
                MessageBox.Show("Vui lòng chọn máy muốn chuyển!");
            else
            {
                //bàn trống
                if (lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex == 0)
                    MessageBox.Show($" {lbMay.Text} đang trống!");
                else
                {
                    frmChuyenMay f = new frmChuyenMay();
                    f.ShowDialog();
                    if (frmChuyenMay.ban != "")
                    {
                        //tìm bàn có bill hiện
                        hoadon bill = HoaDon1.Find(b => b.MaMayTram == idmay);
                        //đổi thành bàn mới
                        bill.MaMayTram = frmChuyenMay.ban;
                        //tìm vị trí bàn cũ trong danh sách để cập nhật trạng thái
                        int old_index = May.FindIndex(t => t.MaMayTram == idmay);
                        //cập nhật trạng thái bàn và trên listview
                        May[old_index].TrangThai = 0;
                        lvMay.Items[old_index].StateImageIndex = 0;
                        //tìm vị trí bàn mới chuyển qua trong danh sách để cập nhật trạng thái
                        int new_index = May.FindIndex(t => t.MaMayTram == frmChuyenMay.ban);
                        //cập nhật trạng thái bàn và trên listview cho bàn mới chuyển qua
                        May[new_index].TrangThai = 1;
                        lvMay.Items[new_index].StateImageIndex = 1;
                        //bàn hiện tại được chọn sẽ là bàn vừa chuyển qua
                        lvMay.Items[new_index].Selected = true;
                        idmay = frmChuyenMay.ban;
                        //xóa bàn đã chọn trên form chuyển bàn
                        frmChuyenMay.ban = "";
                    }
                }
            }
        }

        private void btXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (idmay == "")
                MessageBox.Show("Vui lòng chọn máy cần tắt!");
            else
            {
                //bàn trống
                if (lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex == 0)
                    MessageBox.Show($"{lbMay.Text} đang offline!");
                else
                {
                    if (MessageBox.Show($"Bạn có chắc tắt '{lbMay.Text}' không?", "Chú ý",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    //tìm và xóa hóa đơn
                    hoadon hoadon = HoaDon1.Find(b => b.MaMayTram == idmay);
                    HoaDon1.Remove(hoadon);
                    //bật trạng thái bàn trống
                    lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex = 0;
                    May[lvMay.SelectedIndices[0]].TrangThai = 0;
                    //xóa thông tin giao diện
                    dtpThoiGianVao.Value = DateTime.Now;
                    dgvChiTietHoaDon.Rows.Clear();
                    lbTongTien.Text = lbThoiGianSuDung.Text = cbbTenMon.Text = "";
                }
            }
        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn mở " + lbMay.Text + "?", "Chú ý", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.No) return;
            //Tạo 1 hóa đơn mới
            hoadon hoadon = new hoadon();
            hoadon.MaMayTram = idmay; //Lưu lại số bàn vào hóa đơn
            hoadon.giovao = dtpThoiGianVao.Value = DateTime.Now;//Chốt giờ vào là giờ hiện tại
            //Đổi trạng thái bàm
            lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex = 1;
            May[lvMay.SelectedIndices[0]].TrangThai = 1;
            //Thêm vào list hóa đơn để lưu lại
            HoaDon1.Add(hoadon);
            //không cho bấm vào button tạo hóa đơn
            btTaoHoaDon.Enabled = false;
            
        }
        void showListviewMay()
        {
            LayDuLieuMay();
            int i = 0;
            foreach (may desktop in May) //may dầu tiên là cái cấu trúc ở dòng 21, May thứ 3 là cái List ở dòng 27
            {
                lvMay.Items.Add(desktop.TenMay);
                lvMay.Items[i++].StateImageIndex = desktop.TrangThai;
            }
        }
        int TONGTIEN = 0;
        void XuatThongTinHoaDonCu(hoadon bill)
        {
            dtpThoiGianVao.Value = bill.giovao;
            dgvChiTietHoaDon.Rows.Clear();
            int STT = 0;
            int tongtien = 0;
            if (dgvChiTietHoaDon.Columns.Count < 5)
            {
                dgvChiTietHoaDon.Columns.Clear();
                dgvChiTietHoaDon.Columns.Add("STT", "STT");
                dgvChiTietHoaDon.Columns.Add("Ten", "Tên");
                dgvChiTietHoaDon.Columns.Add("SoLuong", "Số Lượng");
                dgvChiTietHoaDon.Columns.Add("DonViTinh", "Đơn Vị Tính");
                dgvChiTietHoaDon.Columns.Add("ThanhTien", "Thành Tiền");
            }
            foreach (chitiethoadon detail in bill.ChiTietHoaDon)
            {
                dgvChiTietHoaDon.Rows.Add(1);
                DataGridViewRow row = dgvChiTietHoaDon.Rows[STT];
                row.Cells[0].Value = STT + 1;
                row.Cells[1].Value = detail.Ten;
                row.Cells[2].Value = detail.SoLuong;
                row.Cells[3].Value = detail.DonViTinh;
                row.Cells[4].Value = detail.DonViTinh * detail.SoLuong;
                tongtien += detail.DonViTinh * detail.SoLuong;
                STT++;
            }
            lbTongTien.Text = string.Format("{0:0,0}", tongtien);
        }
        private void btThemMon_Click(object sender, EventArgs e)
        {

            if (idmay == "")
                MessageBox.Show("Vui lòng mở máy trước khi thêm món");
            else
            {
                //Bàn trống
                if (lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex == 0)
                    MessageBox.Show("Vui lòng mở máy trước khi thêm món");
                else//Bàn đã chốt hóa đơn
                {
                    if (cbbTenMon.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng chọn món để thêm vào hóa đơn");
                        return;
                    }
                    hoadon hoadon = HoaDon1.Find(b => b.MaMayTram == idmay);
                    //Tạo ra 1 chi tiết
                    chitiethoadon chitiet = new chitiethoadon()
                    {
                        MaDichVu = cbbTenMon.SelectedValue.ToString(),
                        Ten = cbbTenMon.Text,
                        SoLuong = 1,
                        DonViTinh = int.Parse(dsMon.Rows[cbbTenMon.SelectedIndex]["Gia"].ToString())
                    };
                    //Kiểm tra món có trong hóa đơn chưa
                    chitiethoadon ct = hoadon.ChiTietHoaDon.Find(d => d.MaDichVu == chitiet.MaDichVu);
                    if (ct != null)//đã có trong hóa đơn
                        ct.SoLuong += 1;//Tăng số lượng lên 1
                    else
                        hoadon.ChiTietHoaDon.Add(chitiet);//Chưa có thì thêm vào
                    //Xuất ra giao diện
                    XuatThongTinHoaDonCu(hoadon);
                }
            }
        }
        private int Tinhtiengio(DateTime giovao, DateTime giora)
        {
            DataTable dt = DB.LayDuLieu("SELECT Gia FROM DichVu WHERE MaDichVu = 0");
            int gia = int.Parse(dt.Rows[0][0].ToString());
            TimeSpan ts = giora - giovao;
            lbThoiGianSuDung.Text = $"{ts.Hours} giờ {ts.Minutes} phút {ts.Seconds} giây"; ;
            return gia * (int)ts.TotalMinutes;
        }
        int mhd = 1;
        int cthd = 1;    

        private void btThanhToan_Click_1(object sender, EventArgs e)
        {
            if (idmay == "")
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán!");
            else
            {
                //bàn trống
                if (lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex == 0)
                    MessageBox.Show($"Bàn {lbMay.Text} chưa có khách!");
                else
                {
                    //tìm và lưu hóa đơn vào CSDL
                    hoadon hoadon = HoaDon1.Find(b => b.MaMayTram == idmay);
                    //tính tổng tiền
                    DateTime giora = DateTime.Now;
                    int tiengio = Tinhtiengio(hoadon.giovao, giora);
                    int tongtien = hoadon.ChiTietHoaDon.Sum(d => d.SoLuong * d.DonViTinh) + tiengio;
                    //tạo lệnh SQL lưu hóa đơn
                    frmXacNhan f = new frmXacNhan();
                    f.ThoiGianSuDung = lbThoiGianSuDung.Text;
                    f.tienDichvu = hoadon.ChiTietHoaDon.Sum(d => d.SoLuong * d.DonViTinh).ToString();
                    f.tongtien = tongtien.ToString();
                    f.tiengio = tiengio.ToString();
                    f.ShowDialog();                    
                    if (frmXacNhan.xacnhan == "") return;


                    string sql = $"INSERT INTO hoadon(MaHoaDon,GioVao, GioRa, TienGio, TongTien, MaMayTram, MaNhanVien) VALUES" +
                        $"({mhd}+(SELECT MAX(MaHoaDon) FROM hoadon),'{hoadon.giovao.ToString("yyyy-MM-dd hh:mm:ss")}', '{giora.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                        $"'{tiengio}', '{tongtien}', '{hoadon.MaMayTram}', 3);";
                    //duyệt qua chi tiết và tạo SQL lưu chi tiết

                    foreach (chitiethoadon item in hoadon.ChiTietHoaDon)
                    {

                        sql += "\n";
                        sql += $"INSERT INTO ChiTietHoaDon(SoCTHD,MaHoaDon, MaDichVu, SoLuong, DonGia) VALUES" +
                            $" ({cthd}+(SELECT MAX(SoCTHD) FROM ChiTietHoaDon),(SELECT MAX(MaHoaDon) FROM hoadon),'" +
                            $"{item.MaDichVu}','{item.SoLuong}','{item.DonViTinh}');";
                    }
                    /* MessageBox.Show(sql);*/
                    //gọi hàm lưu
                    try
                    {
                        DB.CapNhatDuLieu(sql);
                        MessageBox.Show("Đã lưu thông tin hóa đơn!");
                        //xóa hóa đơn tạm
                        HoaDon1.Remove(hoadon);
                        //bật trạng thái bàn trống
                        lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex = 0;
                        May[lvMay.SelectedIndices[0]].TrangThai = 0;
                        //xóa thông tin giao diện
                        dtpThoiGianVao.Value = DateTime.Now;
                        dgvChiTietHoaDon.Rows.Clear();
                        lbTongTien.Text = lbThoiGianSuDung.Text = cbbTenMon.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Hệ thống đang gặp sự cố, vui lòng thử lại sau ít giây!");
                    }
                }
            }
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            if (idmay == "")
            {
                MessageBox.Show("Vui lòng chọn máy trước khi xóa món");
                return;
            }

            // Bàn trống
            if (lvMay.Items[lvMay.SelectedIndices[0]].StateImageIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn máy trước khi xóa món");
                return;
            }

            // Kiểm tra nếu không có món nào được chọn
            if (dgvChiTietHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món để xóa");
                return;
            }

            // Tìm hóa đơn hiện tại của máy đã chọn
            hoadon hoadon = HoaDon1.Find(b => b.MaMayTram == idmay);
            if (hoadon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn cho máy này");
                return;
            }

            // Xóa các món được chọn từ DataGridView và danh sách chi tiết hóa đơn
            foreach (DataGridViewRow row in dgvChiTietHoaDon.SelectedRows)
            {
                // Lấy mã dịch vụ của món cần xóa
                string tenDichVu = row.Cells[1].Value.ToString();
                // Tìm và xóa món từ danh sách chi tiết hóa đơn
                chitiethoadon chitiet = hoadon.ChiTietHoaDon.Find(d => d.Ten == tenDichVu);
                if (chitiet != null)
                {
                    if (chitiet.SoLuong > 1)
                    {
                        chitiet.SoLuong -= 1;
                    }
                    else
                        hoadon.ChiTietHoaDon.Remove(chitiet);
                }

            }
            // Cập nhật thông tin hiển thị hóa đơn cũ sau khi xóa món
            XuatThongTinHoaDonCu(hoadon);

        }
    }

}

