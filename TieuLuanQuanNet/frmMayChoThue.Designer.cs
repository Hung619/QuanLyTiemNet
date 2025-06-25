
namespace TieuLuanQuanNet
{
    partial class frmMayChoThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMayChoThue));
            this.btChuyenMay = new System.Windows.Forms.Button();
            this.lbThoiGianSuDung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTaoHoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btXoaMon = new System.Windows.Forms.Button();
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.dichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTIEMNETDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTIEMNETDataSet = new TieuLuanQuanNet.QLTIEMNETDataSet();
            this.dichVuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btThemMon = new System.Windows.Forms.Button();
            this.lbMay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btXoaHoaDon = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpThoiGianVao = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMay = new System.Windows.Forms.ListView();
            this.dichVuTableAdapter = new TieuLuanQuanNet.QLTIEMNETDataSetTableAdapters.DichVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btChuyenMay
            // 
            this.btChuyenMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChuyenMay.FlatAppearance.BorderSize = 0;
            this.btChuyenMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChuyenMay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btChuyenMay.ForeColor = System.Drawing.Color.White;
            this.btChuyenMay.Location = new System.Drawing.Point(281, 533);
            this.btChuyenMay.Name = "btChuyenMay";
            this.btChuyenMay.Size = new System.Drawing.Size(134, 43);
            this.btChuyenMay.TabIndex = 20;
            this.btChuyenMay.Text = "Chuyển máy";
            this.btChuyenMay.UseVisualStyleBackColor = false;
            this.btChuyenMay.Click += new System.EventHandler(this.btChuyenMay_Click);
            // 
            // lbThoiGianSuDung
            // 
            this.lbThoiGianSuDung.AutoSize = true;
            this.lbThoiGianSuDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGianSuDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThoiGianSuDung.Location = new System.Drawing.Point(377, 70);
            this.lbThoiGianSuDung.Name = "lbThoiGianSuDung";
            this.lbThoiGianSuDung.Size = new System.Drawing.Size(21, 24);
            this.lbThoiGianSuDung.TabIndex = 19;
            this.lbThoiGianSuDung.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(195, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thời gian đã sử dụng:";
            // 
            // btTaoHoaDon
            // 
            this.btTaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btTaoHoaDon.Enabled = false;
            this.btTaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoHoaDon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btTaoHoaDon.Location = new System.Drawing.Point(18, 533);
            this.btTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTaoHoaDon.Name = "btTaoHoaDon";
            this.btTaoHoaDon.Size = new System.Drawing.Size(118, 43);
            this.btTaoHoaDon.TabIndex = 17;
            this.btTaoHoaDon.Text = "Mở máy";
            this.btTaoHoaDon.UseVisualStyleBackColor = false;
            this.btTaoHoaDon.Click += new System.EventHandler(this.btTaoHoaDon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chi tiết";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(110, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chọn món để thêm/xóa trong hóa đơn";
            // 
            // btXoaMon
            // 
            this.btXoaMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoaMon.Location = new System.Drawing.Point(498, 143);
            this.btXoaMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(56, 43);
            this.btXoaMon.TabIndex = 13;
            this.btXoaMon.Text = "-";
            this.toolTip1.SetToolTip(this.btXoaMon, "Xóa món ra khỏi hóa đơn");
            this.btXoaMon.UseVisualStyleBackColor = true;
            this.btXoaMon.Click += new System.EventHandler(this.btXoaMon_Click);
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dichVuBindingSource, "MaDichVu", true));
            this.cbbTenMon.DataSource = this.dichVuBindingSource1;
            this.cbbTenMon.DisplayMember = "Ten";
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(150, 156);
            this.cbbTenMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(231, 24);
            this.cbbTenMon.TabIndex = 12;
            // 
            // dichVuBindingSource
            // 
            this.dichVuBindingSource.DataMember = "DichVu";
            this.dichVuBindingSource.DataSource = this.qLTIEMNETDataSetBindingSource;
            // 
            // qLTIEMNETDataSetBindingSource
            // 
            this.qLTIEMNETDataSetBindingSource.DataSource = this.qLTIEMNETDataSet;
            this.qLTIEMNETDataSetBindingSource.Position = 0;
            // 
            // qLTIEMNETDataSet
            // 
            this.qLTIEMNETDataSet.DataSetName = "QLTIEMNETDataSet";
            this.qLTIEMNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dichVuBindingSource1
            // 
            this.dichVuBindingSource1.DataMember = "DichVu";
            this.dichVuBindingSource1.DataSource = this.qLTIEMNETDataSetBindingSource;
            // 
            // btThemMon
            // 
            this.btThemMon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThemMon.Location = new System.Drawing.Point(433, 143);
            this.btThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(59, 43);
            this.btThemMon.TabIndex = 11;
            this.btThemMon.Text = "+";
            this.toolTip1.SetToolTip(this.btThemMon, "Thêm món vào hóa đơn");
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // lbMay
            // 
            this.lbMay.AutoSize = true;
            this.lbMay.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMay.Location = new System.Drawing.Point(29, 22);
            this.lbMay.Name = "lbMay";
            this.lbMay.Size = new System.Drawing.Size(79, 41);
            this.lbMay.TabIndex = 0;
            this.lbMay.Text = "Máy";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.Maroon;
            this.btThanhToan.FlatAppearance.BorderSize = 0;
            this.btThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.Location = new System.Drawing.Point(418, 533);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(136, 43);
            this.btThanhToan.TabIndex = 10;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click_1);
            // 
            // btXoaHoaDon
            // 
            this.btXoaHoaDon.BackColor = System.Drawing.Color.Gray;
            this.btXoaHoaDon.FlatAppearance.BorderSize = 0;
            this.btXoaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaHoaDon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaHoaDon.ForeColor = System.Drawing.Color.White;
            this.btXoaHoaDon.Location = new System.Drawing.Point(142, 533);
            this.btXoaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoaHoaDon.Name = "btXoaHoaDon";
            this.btXoaHoaDon.Size = new System.Drawing.Size(133, 43);
            this.btXoaHoaDon.TabIndex = 9;
            this.btXoaHoaDon.Text = "Tắt máy";
            this.btXoaHoaDon.UseVisualStyleBackColor = false;
            this.btXoaHoaDon.Click += new System.EventHandler(this.btXoaHoaDon_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTongTien.Location = new System.Drawing.Point(151, 495);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(26, 29);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "0";
            this.lbTongTien.Click += new System.EventHandler(this.lbTongTien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian bắt đầu:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.btTaoHoaDon);
            this.panel2.Controls.Add(this.btChuyenMay);
            this.panel2.Controls.Add(this.lbThoiGianSuDung);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btXoaMon);
            this.panel2.Controls.Add(this.cbbTenMon);
            this.panel2.Controls.Add(this.btThemMon);
            this.panel2.Controls.Add(this.btThanhToan);
            this.panel2.Controls.Add(this.btXoaHoaDon);
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvChiTietHoaDon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dtpThoiGianVao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(297, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 592);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AllowUserToOrderColumns = true;
            this.dgvChiTietHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(13, 189);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.ReadOnly = true;
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(541, 302);
            this.dgvChiTietHoaDon.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên món";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đ.Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "T.Tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "______________________________________________________________";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel3.Controls.Add(this.lbMay);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 90);
            this.panel3.TabIndex = 2;
            // 
            // dtpThoiGianVao
            // 
            this.dtpThoiGianVao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpThoiGianVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianVao.Location = new System.Drawing.Point(363, 20);
            this.dtpThoiGianVao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpThoiGianVao.Name = "dtpThoiGianVao";
            this.dtpThoiGianVao.Size = new System.Drawing.Size(191, 22);
            this.dtpThoiGianVao.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bantrong.png");
            this.imageList1.Images.SetKeyName(1, "banconguoi.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 592);
            this.panel1.TabIndex = 2;
            // 
            // lvMay
            // 
            this.lvMay.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMay.HideSelection = false;
            this.lvMay.LargeImageList = this.imageList1;
            this.lvMay.Location = new System.Drawing.Point(0, 0);
            this.lvMay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvMay.MultiSelect = false;
            this.lvMay.Name = "lvMay";
            this.lvMay.Size = new System.Drawing.Size(297, 592);
            this.lvMay.SmallImageList = this.imageList1;
            this.lvMay.StateImageList = this.imageList1;
            this.lvMay.TabIndex = 0;
            this.lvMay.UseCompatibleStateImageBehavior = false;
            this.lvMay.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMay_ItemSelectionChanged);
            // 
            // dichVuTableAdapter
            // 
            this.dichVuTableAdapter.ClearBeforeFill = true;
            // 
            // frmMayChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMayChoThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Cho Thuê";
            this.Load += new System.EventHandler(this.frmMayChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btChuyenMay;
        private System.Windows.Forms.Label lbThoiGianSuDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTaoHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btXoaMon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbbTenMon;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.Label lbMay;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btXoaHoaDon;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpThoiGianVao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMay;
        private System.Windows.Forms.BindingSource qLTIEMNETDataSetBindingSource;
        private QLTIEMNETDataSet qLTIEMNETDataSet;
        private System.Windows.Forms.BindingSource dichVuBindingSource;
        private QLTIEMNETDataSetTableAdapters.DichVuTableAdapter dichVuTableAdapter;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.BindingSource dichVuBindingSource1;
    }
}