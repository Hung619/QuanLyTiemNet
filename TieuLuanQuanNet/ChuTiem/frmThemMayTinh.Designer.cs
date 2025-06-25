
namespace TieuLuanQuanNet
{
    partial class frmThemMayTinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbCauHinh = new System.Windows.Forms.ComboBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qLTIEMNETDataSet1 = new TieuLuanQuanNet.QLTIEMNETDataSet1();
            this.cauHinhMayTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cauHinhMayTinhTableAdapter = new TieuLuanQuanNet.QLTIEMNETDataSet1TableAdapters.CauHinhMayTinhTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHinhMayTinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 100);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Máy";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(177, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbCauHinh
            // 
            this.cbbCauHinh.DataSource = this.cauHinhMayTinhBindingSource;
            this.cbbCauHinh.DisplayMember = "CauHinh";
            this.cbbCauHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCauHinh.FormattingEnabled = true;
            this.cbbCauHinh.Location = new System.Drawing.Point(152, 212);
            this.cbbCauHinh.Name = "cbbCauHinh";
            this.cbbCauHinh.Size = new System.Drawing.Size(223, 24);
            this.cbbCauHinh.TabIndex = 15;
            // 
            // txtSTT
            // 
            this.txtSTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTT.Location = new System.Drawing.Point(152, 151);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(223, 22);
            this.txtSTT.TabIndex = 13;
            // 
            // txtTenMay
            // 
            this.txtTenMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMay.Location = new System.Drawing.Point(152, 183);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(223, 22);
            this.txtTenMay.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "STT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cấu hình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên máy:";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTrangThai.Location = new System.Drawing.Point(152, 249);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(223, 24);
            this.cbbTrangThai.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(51, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trạng thái:";
            // 
            // qLTIEMNETDataSet1
            // 
            this.qLTIEMNETDataSet1.DataSetName = "QLTIEMNETDataSet1";
            this.qLTIEMNETDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cauHinhMayTinhBindingSource
            // 
            this.cauHinhMayTinhBindingSource.DataMember = "CauHinhMayTinh";
            this.cauHinhMayTinhBindingSource.DataSource = this.qLTIEMNETDataSet1;
            // 
            // cauHinhMayTinhTableAdapter
            // 
            this.cauHinhMayTinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 362);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCauHinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenMay);
            this.Name = "frmThemMayTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemMayTinh";
            this.Load += new System.EventHandler(this.frmThemMayTinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLTIEMNETDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHinhMayTinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbCauHinh;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label5;
        private QLTIEMNETDataSet1 qLTIEMNETDataSet1;
        private System.Windows.Forms.BindingSource cauHinhMayTinhBindingSource;
        private QLTIEMNETDataSet1TableAdapters.CauHinhMayTinhTableAdapter cauHinhMayTinhTableAdapter;
    }
}